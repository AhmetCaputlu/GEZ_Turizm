using AutoMapper;
using AutoMapper.QueryableExtensions;
using Azure;
using BusinessLogic.DTOs.Companies.PartnerCompanies;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Repositories.CompanyR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BusinessLogic.Services.CompanyS
{
    public class PartnerCompanyService : GenericCompanyService<PartnerCompany, PartnerCompanyResponseDTO, PartnerCompanyRequestDTO, PartnerCompanyFilterModel>, IPartnerCompanyService
    {
        private readonly IPartnerCompanyRepository _repository;
        private readonly IMapper _mapper;

        public PartnerCompanyService(IPartnerCompanyRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<PartnerCompanyResponseDTO, PartnerCompanyFilterModel>> GetDynamicFilteredEntities(ResultDTO<PartnerCompanyResponseDTO, PartnerCompanyFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<PartnerCompanyResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
    }
}
