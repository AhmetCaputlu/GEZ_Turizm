using System.Runtime.InteropServices;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Employees;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.EmployeeR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.EmployeeS
{
    public class ContractEmployeeService : GenericEmployeeService<ContractEmployee, ContractEmployeeResponseDTO, ContractEmployeeRequestDTO, ContractEmployeeFilterModel>, IContractEmployeeService
    {
        private readonly IContractEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public ContractEmployeeService(IContractEmployeeRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<ContractEmployeeResponseDTO, ContractEmployeeFilterModel>> GetDynamicFilteredEntities(ResultDTO<ContractEmployeeResponseDTO, ContractEmployeeFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<ContractEmployeeResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
