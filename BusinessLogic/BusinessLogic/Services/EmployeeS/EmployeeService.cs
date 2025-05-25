using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Activities;
using BusinessLogic.DTOs.Employees;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.EmployeeR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.EmployeeS
{
    public class EmployeeService : GenericEmployeeService<Employee, EmployeeResponseDTO, EmployeeRequestDTO, EmployeeFilterModel>, IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<EmployeeResponseDTO, EmployeeFilterModel>> GetDynamicFilteredEntities(ResultDTO<EmployeeResponseDTO, EmployeeFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<EmployeeResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
