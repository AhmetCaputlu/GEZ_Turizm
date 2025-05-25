using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Companies.PartnerCompanies;
using BusinessLogic.Helpers;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Repositories.CompanyR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.CompanyS
{
    public class TransactionService : GenericService<PartnerCompanyTransaction, TransactionResponseDTO, TransactionRequestDTO, TransactionFilterModel>, ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IPartnerCompanyRepository _pcrepository;
        private readonly IMapper _mapper;
        public TransactionService(ITransactionRepository repository, IPartnerCompanyRepository pcrepository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _pcrepository = pcrepository;
        }
        public override async Task<ResultDTO<TransactionResponseDTO, TransactionFilterModel>> GetDynamicFilteredEntities(ResultDTO<TransactionResponseDTO, TransactionFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<TransactionResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
                if (result.List.Any())
                {
                    result.NotificationType = new NotificationDTO { ResultType = NotificationType.Success };
                    return result;
                }
                result.NotificationType = new NotificationDTO
                {
                    ResultType = NotificationType.Null,
                    Description = "Kriterlere uygun veri bulunamadı!!"
                };
                return result;
            }
            catch (OperationCanceledException oce)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
                return result;
            }
            catch (Exception ex)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
                return result;
            }
        }
        public override async Task<NotificationDTO> CreateAsync(TransactionRequestDTO DTO, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                var partnerCompany = await _pcrepository.GetByIdAsync(DTO.PartnerCompanyId, token);
                if (DTO.Type == TransactionType.Purchase)
                {
                    partnerCompany.Credit += DTO.TotalCost;
                }
                else if (DTO.Type == TransactionType.Sale)
                {
                    partnerCompany.Debit += DTO.TotalCost;
                }
                await _pcrepository.Update(partnerCompany, token);
                var newTransaction = _mapper.Map<PartnerCompanyTransaction>(DTO);
                newTransaction.Guid = Guid.NewGuid().ToString();
                newTransaction.CreatedDate = DateTime.Now;
                newTransaction.CreatedID = UniqueIdentify.GetUserID();
                newTransaction.CreatedIPAddress = IPAdress.GetIpAdress();
                newTransaction.IsUpdated = false;
                await _repository.CreateAsync(newTransaction, token);
                return new NotificationDTO
                {
                    ResultType = NotificationType.Success,
                    Description = "Veritabanı kaydı başarıyla tamamlandı!"
                };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
    }
}
