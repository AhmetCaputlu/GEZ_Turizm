using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Companies.PartnerCompanies;
using BusinessLogic.DTOs.Vehicles;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Repositories.VehicleR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.VehicleS
{
    public class RentalVehicleService : GenericVehicleService<RentalVehicle, RentalVehicleResponseDTO, RentalVehicleRequestDTO, RentalVehicleFilterModel>, IRentalVehicleService
    {
        private readonly IRentalVehicleRepository _repository;
        private readonly IMapper _mapper;

        public RentalVehicleService(IRentalVehicleRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<RentalVehicleResponseDTO, RentalVehicleFilterModel>> GetDynamicFilteredEntities(ResultDTO<RentalVehicleResponseDTO, RentalVehicleFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<RentalVehicleResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
