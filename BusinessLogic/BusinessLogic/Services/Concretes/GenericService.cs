using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.Concretes
{
    public class GenericService<TEntity, TResponse, TRequest, TFilterEntity> :
        IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : class, IEntity where TResponse : BaseResponseModelDTO where TRequest : BaseRequestModelDTO
        where TFilterEntity : BaseFilterModel
    {
        private readonly IGenericRepository<TEntity, TFilterEntity> _repository;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository<TEntity, TFilterEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #region Manuel Methods
        //public IEnumerable<TResponse> GetAllEntities()
        //{
        //    return _repository.GetAllEntities().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllActives()
        //{
        //    return _repository.GetAllActives().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllPassives()
        //{
        //    return _repository.GetAllPassives().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllUnknowns()
        //{
        //    return _repository.GetAllUnknowns().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllUpdated()
        //{
        //    return _repository.GetAllUpdated().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllNotUpdated()
        //{
        //    return _repository.GetAllNotUpdated().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}

        //public IEnumerable<TResponse> GetEntitiesBetweenId(int firstId, int lastId)
        //{
        //    return _repository.GetEntitiesBetweenId(firstId,lastId).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesByCreatedDate(DateTime dateTime)
        //{
        //    return _repository.GetEntitiesByCreatedDate(dateTime).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesByUpdatedDate(DateTime dateTime)
        //{
        //    return _repository.GetEntitiesByUpdatedDate(dateTime).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate)
        //{
        //    return _repository.GetEntitiesBetweenCreatedDates(firstDate, lastDate).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate)
        //{
        //    return _repository.GetEntitiesBetweenUpdatedDates(firstDate, lastDate).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //} 
        #endregion
        public virtual async Task<IEnumerable<TResponse>> GetDynamicFilteredEntities(TFilterEntity filterModel)
        {
            return await _repository.GetDynamicFilteredEntities(filterModel)
        .ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToListAsync();
        }
        public async Task<TResponse> GetByIdAsync(int Id)
        {
            return _mapper.Map<TResponse>(await _repository.GetByIdAsync(Id));
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
        public async Task DeleteRangeSelectAsync(int first, int last)
        {
            await _repository.DeleteRangeSelectAsync(first, last);
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
