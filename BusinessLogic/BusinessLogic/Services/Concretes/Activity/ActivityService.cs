using BusinessLogic.DTOs.BasicDTOs.Abstracts;
using BusinessLogic.Services.Abstracts.Activity;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts.Activity;

namespace BusinessLogic.Services.Concretes.Activity
{
    public class ActivityService<T, F> : IActivityService<T, F> where T : class, IEntity where F : BaseModelDTO
    {
        public Task CreateAsync(F DTO)
        {
            throw new NotImplementedException();
        }

        public Task CreateBulkAsync(List<F> DTOs)
        {
            throw new NotImplementedException();
        }

        public Task CreateRangeAsync(List<F> DTOs)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(List<F> DTOs)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeSelectAsync(int first, int last)
        {
            throw new NotImplementedException();
        }

        public Task DestroyAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DestroyBulkAsync(List<T> values)
        {
            throw new NotImplementedException();
        }

        public Task DestroyRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task DestroyRangeSelectAsync(int first, int last)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetActivitiesByStartDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetAllNotUpdated()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetAllPassives()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetAllUnknowns()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetAllUpdated()
        {
            throw new NotImplementedException();
        }

        public Task<F> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetEntitiesBetweenId(int firstId, int lastId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetEntitiesByCreatedDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F> GetEntitiesByUpdatedDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SearchActivityByDescription(string description)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SearchActivityByRegionId(int regionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SearchByActivityName(string activityName)
        {
            throw new NotImplementedException();
        }

        public Task Update(F DTO)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBulkAsync(List<F> DTOs)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<F> DTOs)
        {
            throw new NotImplementedException();
        }
    }
}
