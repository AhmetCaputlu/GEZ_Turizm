using AutoMapper;
using BusinessLogic.DTOs.BasicDTOs.Abstracts;
using BusinessLogic.DTOs.BasicDTOs.Models.WebUser;
using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.Products;
using DataAccess.Repositories.Abstracts;

namespace BusinessLogic.Services.Concretes
{
    public class Service<T> : IService<T> where T : class, IEntity
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;
        public Service(IRepository<T> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<T> GetAllEntities()
        {
            return _repository.GetAllEntities();
        }
        public IEnumerable<T> GetAllActives()
        {
            return _repository.GetAllActives();
        }
        public IEnumerable<T> GetAllPassives()
        {
            return _repository.GetAllPassives();
        }
        public IEnumerable<T> GetAllUnknowns()
        {
            return _repository.GetAllUnknowns();
        }
        public IEnumerable<T> GetAllUpdated()
        {
            return _repository.GetAllUpdated();
        }
        public IEnumerable<T> GetAllNotUpdated()
        {
            return _repository.GetAllNotUpdated();
        }
        public Task<T> GetByIdAsync(int Id)
        {
            return _repository.GetByIdAsync(Id);
        }
        public IEnumerable<T> GetEntitiesBetweenId(int firstId, int lastId)
        {
            return _repository.GetEntitiesBetweenId(firstId, lastId);
        }
        public IEnumerable<T> GetEntitiesByCreatedDate(DateTime dateTime)
        {
            return _repository.GetEntitiesByCreatedDate(dateTime);
        }
        public IEnumerable<T> GetEntitiesByUpdatedDate(DateTime dateTime)
        {
            return _repository.GetEntitiesByUpdatedDate(dateTime);
        }
        public IEnumerable<T> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate)
        {
            return _repository.GetEntitiesBetweenCreatedDates(firstDate, lastDate);
        }
        public IEnumerable<T> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate)
        {
            return _repository.GetEntitiesBetweenUpdatedDates(firstDate, lastDate);
        }
        public Task CreateAsync(T entity)
        {
            return _repository.CreateAsync(entity);
        }
        public Task CreateRangeAsync(List<T> entities)
        {
            return _repository.CreateRangeAsync(entities);
        }
        public Task CreateBulkAsync(List<T> values)
        {
            return _repository.CreateBulkAsync(values);
        }
        public Task Update(T entity)
        {
            return _repository.Update(entity);
        }
        public Task UpdateRangeAsync(List<T> entities)
        {
            return _repository.UpdateRangeAsync(entities);
        }
        public Task UpdateBulkAsync(List<T> values)
        {
            return _repository.UpdateBulkAsync(values);
        }
        public Task DeleteAsync(int Id)
        {
            return _repository.DeleteAsync(Id);
        }
        public Task DeleteRangeSelectAsync(int first, int last)
        {
            return _repository.DeleteRangeSelectAsync(first, last);
        }
        public Task DeleteRangeAsync(List<T> values)
        {
            return _repository.DeleteRangeAsync(values);
        }
        public Task DestroyAsync(int Id)
        {
            return _repository.DestroyAsync(Id);
        }
        public Task DestroyRangeSelectAsync(int first, int last)
        {
            return _repository.DestroyRangeSelectAsync(first, last);
        }
        public Task DestroyRangeAsync(List<T> entities)
        {
            return _repository.DestroyRangeAsync(entities);
        }
        public Task DestroyBulkAsync(List<T> values)
        {
            return _repository.DestroyBulkAsync(values);
        }
    }
}
