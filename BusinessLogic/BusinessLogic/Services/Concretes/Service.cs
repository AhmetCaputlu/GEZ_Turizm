using AutoMapper;
using BusinessLogic.DTOs.BasicDTOs.Abstracts;
using BusinessLogic.DTOs.BasicDTOs.Models.WebUser;
using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;

namespace BusinessLogic.Services.Concretes
{
    public class Service<T, F> : IService<T, F> where T : class, IEntity where F : BaseModelDTO
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;
        public Service(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<F> GetAllEntities()
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetAllEntities());
        }
        public IEnumerable<F> GetAllActives()
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetAllActives());
        }
        public IEnumerable<F> GetAllPassives()
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetAllPassives());
        }
        public IEnumerable<F> GetAllUnknowns()
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetAllUnknowns());
        }
        public IEnumerable<F> GetAllUpdated()
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetAllUpdated());
        }
        public IEnumerable<F> GetAllNotUpdated()
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetAllNotUpdated());
        }
        public async Task<F> GetByIdAsync(int Id)
        {
            return _mapper.Map<F>(await _repository.GetByIdAsync(Id));
        }
        public IEnumerable<F> GetEntitiesBetweenId(int firstId, int lastId)
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetEntitiesBetweenId(firstId, lastId));
        }
        public IEnumerable<F> GetEntitiesByCreatedDate(DateTime dateTime)
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetEntitiesByCreatedDate(dateTime));
        }
        public IEnumerable<F> GetEntitiesByUpdatedDate(DateTime dateTime)
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetEntitiesByUpdatedDate(dateTime));
        }
        public IEnumerable<F> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate)
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetEntitiesBetweenCreatedDates(firstDate, lastDate));
        }
        public IEnumerable<F> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate)
        {
            return _mapper.Map<IEnumerable<F>>(_repository.GetEntitiesBetweenUpdatedDates(firstDate, lastDate));
        }
        public async Task CreateAsync(F DTO)
        {
            await _repository.CreateAsync(_mapper.Map<T>(DTO));
        }
        public async Task CreateRangeAsync(List<F> DTOs)
        {
            await _repository.CreateRangeAsync(_mapper.Map<List<T>>(DTOs));
        }
        public async Task CreateBulkAsync(List<F> DTOs)
        {
            await _repository.CreateBulkAsync(_mapper.Map<List<T>>(DTOs));
        }
        public async Task Update(F DTO)
        {
            await _repository.Update(_mapper.Map<T>(DTO));
        }
        public async Task UpdateRangeAsync(List<F> DTOs)
        {
            await _repository.UpdateRangeAsync(_mapper.Map<List<T>>(DTOs));
        }
        public async Task UpdateBulkAsync(List<F> DTOs)
        {
            await _repository.UpdateBulkAsync(_mapper.Map<List<T>>(DTOs));
        }
        public async Task DeleteAsync(int Id)
        {
            await _repository.DeleteAsync(Id);
        }
        public async Task DeleteRangeSelectAsync(int first, int last)
        {
            await _repository.DeleteRangeSelectAsync(first, last);
        }
        public async Task DeleteRangeAsync(List<F> DTOs)
        {
            await _repository.DeleteRangeAsync(_mapper.Map<List<T>>(DTOs));
        }
        public async Task DestroyAsync(int Id)
        {
            await _repository.DestroyAsync(Id);
        }
        public async Task DestroyRangeSelectAsync(int first, int last)
        {
            await _repository.DestroyRangeSelectAsync(first, last);
        }
        public async Task DestroyRangeAsync(List<T> entities)
        {
            await _repository.DestroyRangeAsync(entities);
        }
        public async Task DestroyBulkAsync(List<T> values)
        {
            await _repository.DestroyBulkAsync(values);
        }
    }
}
