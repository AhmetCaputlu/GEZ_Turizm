using BusinessLogic.DTOs.BasicDTOs.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.Services.Abstracts
{
    public interface IService<T,F> where T : class, IEntity where F : BaseModelDTO
    {
        IEnumerable<F> GetAllEntities();
        IEnumerable<F> GetAllActives();
        IEnumerable<F> GetAllPassives();
        IEnumerable<F> GetAllUnknowns();
        IEnumerable<F> GetAllUpdated();
        IEnumerable<F> GetAllNotUpdated();
        Task<F> GetByIdAsync(int Id);
        IEnumerable<F> GetEntitiesBetweenId(int firstId, int lastId);
        IEnumerable<F> GetEntitiesByCreatedDate(DateTime dateTime);
        IEnumerable<F> GetEntitiesByUpdatedDate(DateTime dateTime);
        IEnumerable<F> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate);
        IEnumerable<F> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate);
        Task CreateAsync(F DTO);
        Task CreateRangeAsync(List<F> DTOs);
        Task CreateBulkAsync(List<F> DTOs);
        Task Update(F DTO);
        Task UpdateRangeAsync(List<F> DTOs);
        Task UpdateBulkAsync(List<F> DTOs);
        Task DeleteAsync(int Id);
        Task DeleteRangeSelectAsync(int first, int last);
        Task DeleteRangeAsync(List<F> DTOs);
        Task DestroyAsync(int Id);
        Task DestroyRangeSelectAsync(int first, int last);
        Task DestroyRangeAsync(List<T> entities);
        Task DestroyBulkAsync(List<T> values);
    }
}
