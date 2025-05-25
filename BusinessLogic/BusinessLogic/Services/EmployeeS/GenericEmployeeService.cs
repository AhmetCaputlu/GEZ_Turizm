using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Repositories.EmployeeR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.EmployeeS
{
    public class GenericEmployeeService<TEntity, TResponse, TRequest, TFilterEntity> :
        GenericService<TEntity, TResponse, TRequest, TFilterEntity>,
        IGenericEmployeeService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : BaseEmployeeModel where TResponse : BaseEmployeeResponseDTO
        where TRequest : BaseEmployeeRequestDTO where TFilterEntity : BaseEmployeeFilterModel, new()
    {
        private readonly IGenericEmployeeRepository<TEntity, TFilterEntity> _repository;
        private readonly IMapper _mapper;
        public GenericEmployeeService(IGenericEmployeeRepository<TEntity, TFilterEntity> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<TResponse, TFilterEntity>> GetDynamicFilteredEntities(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToListAsync(token);
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
