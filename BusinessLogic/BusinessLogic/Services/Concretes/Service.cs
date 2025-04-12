using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.RequestDTOs.Abstracts;
using BusinessLogic.DTOs.ResponseDTOs.Abstracts;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;

namespace BusinessLogic.Services.Concretes
{
    public class Service<TEntity, TResponse, TRequest>
        where TEntity : class, IEntity where TResponse : BaseResponseDTO where TRequest : BaseRequestDTO
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        public Service(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<TResponse> GetAllEntities()
        {
            return _repository.GetAllEntities().ProjectTo<TResponse>(_mapper.ConfigurationProvider);
        }
        public IEnumerable<TResponse> GetAllEntities2()
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetAllEntities());
        }
        public IEnumerable<TResponse> GetAllActives()
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetAllActives());
        }
        public IEnumerable<TResponse> GetAllPassives()
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetAllPassives());
        }
        public IEnumerable<TResponse> GetAllUnknowns()
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetAllUnknowns());
        }
        public IEnumerable<TResponse> GetAllUpdated()
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetAllUpdated());
        }
        public IEnumerable<TResponse> GetAllNotUpdated()
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetAllNotUpdated());
        }
        public async Task<TResponse> GetByIdAsync(int Id)
        {
            return _mapper.Map<TResponse>(await _repository.GetByIdAsync(Id));
        }
        public IEnumerable<TResponse> GetEntitiesBetweenId(int TResponseirstId, int lastId)
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetEntitiesBetweenId(TResponseirstId, lastId));
        }
        public IEnumerable<TResponse> GetEntitiesByCreatedDate(DateTime dateTime)
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetEntitiesByCreatedDate(dateTime));
        }
        public IEnumerable<TResponse> GetEntitiesByUpdatedDate(DateTime dateTime)
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetEntitiesByUpdatedDate(dateTime));
        }
        public IEnumerable<TResponse> GetEntitiesBetweenCreatedDates(DateTime TResponseirstDate, DateTime lastDate)
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetEntitiesBetweenCreatedDates(TResponseirstDate, lastDate));
        }
        public IEnumerable<TResponse> GetEntitiesBetweenUpdatedDates(DateTime TResponseirstDate, DateTime lastDate)
        {
            return _mapper.Map<IEnumerable<TResponse>>(_repository.GetEntitiesBetweenUpdatedDates(TResponseirstDate, lastDate));
        }
        public async Task CreateAsync(TRequest DTO)
        {
            await _repository.CreateAsync(_mapper.Map<TEntity>(DTO));
        }
        public async Task CreateRangeAsync(List<TRequest> DTOs)
        {
            await _repository.CreateRangeAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task CreateBulkAsync(List<TRequest> DTOs)
        {
            await _repository.CreateBulkAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task Update(TRequest DTO)
        {
            await _repository.Update(_mapper.Map<TEntity>(DTO));
        }
        public async Task UpdateRangeAsync(List<TRequest> DTOs)
        {
            await _repository.UpdateRangeAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task UpdateBulkAsync(List<TRequest> DTOs)
        {
            await _repository.UpdateBulkAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task DeleteAsync(int Id)
        {
            await _repository.DeleteAsync(Id);
        }
        public async Task DeleteRangeSelectAsync(int TResponseirst, int last)
        {
            await _repository.DeleteRangeSelectAsync(TResponseirst, last);
        }
        public async Task DeleteRangeAsync(List<TRequest> DTOs)
        {
            await _repository.DeleteRangeAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task DestroyAsync(int Id)
        {
            await _repository.DestroyAsync(Id);
        }
        public async Task DestroyRangeSelectAsync(int first, int last)
        {
            await _repository.DestroyRangeSelectAsync(first, last);
        }
        public async Task DestroyRangeAsync(List<TEntity> entities)
        {
            await _repository.DestroyRangeAsync(entities);
        }
        public async Task DestroyBulkAsync(List<TEntity> values)
        {
            await _repository.DestroyBulkAsync(values);
        }
    }
}
