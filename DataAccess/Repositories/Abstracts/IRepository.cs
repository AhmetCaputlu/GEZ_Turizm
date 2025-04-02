using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Repositories.Abstracts
{
    public interface IRepository<T> where T : class,IEntity
    {
        IQueryable<T> GetAllEntities();
        IQueryable<T> GetAllActives();
        IQueryable<T> GetAllPassives();
        IQueryable<T> GetAllUnknowns();
        IQueryable<T> GetAllUpdated();
        Task<T> GetByIdAsync(int Id);
        Task<IQueryable<T>> GetEntitiesByCreatedDateAsync(DateTime dateTime);
        Task<IQueryable<T>> GetEntitiesByUpdatedDateAsync(DateTime dateTime);
        Task<IQueryable<T>> GetEntitiesBetweenCreatedDatesAsync(DateTime firstDate, DateTime lastDate);
        Task<IQueryable<T>> GetEntitiesBetweenUpdatedDatesAsync(DateTime firstDate, DateTime lastDate); 
        Task CreateAsync(T entity);
        Task CreateRangeAsync(IEnumerable<T> entities);
        Task CreateBulkAsync(IEnumerable<T> values);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);
        Task UpdateBulkAsync(IEnumerable<T> values);
        Task DeleteAsync(int Id);
        Task DeleteRangeAsync(IEnumerable<T> entities);
        Task DeleteBulkAsync(IEnumerable<T> values);
        Task DestroyAsync(int Id);
        Task DestroyRangeAsync(IEnumerable<T> entities);
        Task DestroyBulkRangeAsync(IEnumerable<T> values);

    }
}
//Bu sınıf webuserprofile hariç her sınıfa kontrol sağlayacak.
//Webuser profile için özel bir arayüz oluştururuz.
//Her abstract classımız için ayrı bir generic yazacağız.
//Her somut sınıfımız için özel bir arayüz ve concrete repository oluşturacağız.
//Yarın konsol ile testlerimizi gerçekleştiririz.
//Repo yarın bitmeli =) ltfnn...