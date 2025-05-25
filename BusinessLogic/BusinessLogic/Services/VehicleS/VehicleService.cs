using System.Runtime.InteropServices;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Companies.PartnerCompanies;
using BusinessLogic.DTOs.Vehicles;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Repositories.VehicleR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.VehicleS
{
    public class VehicleService : GenericVehicleService<DataAccess.Entities.Models.Vehicles.Vehicle, VehicleResponseDTO, VehicleRequestDTO, VehicleFilterModel>, IVehicleService
    {
        private readonly IVehicleRepository _repository;
        private readonly IMapper _mapper;
        public VehicleService(IVehicleRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<VehicleResponseDTO, VehicleFilterModel>> GetDynamicFilteredEntities(ResultDTO<VehicleResponseDTO, VehicleFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<VehicleResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
