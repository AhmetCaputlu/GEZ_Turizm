using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Orders;
using BusinessLogic.DTOs.Regions;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;
using DataAccess.Repositories.RegionR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.RegionS
{
    public class CountryService : GenericService<Country, CountryResponseDTO, CountryRequestDTO, CountryFilterModel>, ICountryService
    {
        private readonly ICountryRepository _repository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<CountryResponseDTO, CountryFilterModel>> GetDynamicFilteredEntities(ResultDTO<CountryResponseDTO, CountryFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<CountryResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
