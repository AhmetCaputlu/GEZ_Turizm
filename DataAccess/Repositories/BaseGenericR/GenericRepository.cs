using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities.FilterModels.BaseModel;
namespace DataAccess.Repositories

{
    public class GenericRepository<TEntity, TFilterEntity> : IGenericRepository<TEntity, TFilterEntity>
        where TEntity : class, IEntity where TFilterEntity : BaseFilterModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<TEntity> _dbset;
        public GenericRepository(GezTurizmContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }
        #region Manuel Methods
        //public I_dbsetable<T> GetAllEntities()
        //{
        //    return _dbset;

        //}
        //public I_dbsetable<T> GetAllActives()
        //{
        //    return _dbset.Where(x => x.Status == DataStatus.Active);
        //}
        //public I_dbsetable<T> GetAllPassives()
        //{
        //    return _dbset.Where(x => x.Status == DataStatus.Passive);
        //}
        //public I_dbsetable<T> GetAllUnknowns()
        //{
        //    return _dbset.Where(x => x.Status == DataStatus.Unknown);
        //}
        //public I_dbsetable<T> GetAllUpdated()
        //{
        //    return _dbset.Where(x => x.IsUpdated == true);
        //}
        //public I_dbsetable<T> GetAllNotUpdated()
        //{
        //    return _dbset.Where(x => x.IsUpdated == false);
        //}
        //public I_dbsetable<T> GetEntitiesBetweenId(int firstId, int lastId)
        //{
        //    return _dbset.Where(x => x.Id >= firstId && x.Id <= lastId);
        //}
        //public I_dbsetable<T> GetEntitiesByCreatedDate(DateTime dateTime)
        //{
        //    return _dbset.Where(x => x.CreatedDate.Date == dateTime.Date);
        //}
        //public I_dbsetable<T> GetEntitiesByUpdatedDate(DateTime dateTime)
        //{
        //    return _dbset.Where(x => x.UpdatedDate.Value.Date == dateTime.Date);
        //}
        //public I_dbsetable<T> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate)
        //{
        //    return _dbset.Where(x => x.CreatedDate.Date >= firstDate.Date && x.CreatedDate.Date <= lastDate.Date);
        //}
        //public I_dbsetable<T> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate)
        //{
        //    return _dbset.Where(x => x.UpdatedDate.Value.Date >= firstDate.Date &&
        //    x.UpdatedDate.Value.Date <= lastDate.Date);
        //} 
        #endregion

        public virtual IQueryable<TEntity> GetDynamicFilteredEntities(TFilterEntity filterModel)
        {
            IQueryable<TEntity> filter = _dbset;
            if (filterModel.FirstId.HasValue && filterModel.LastId.HasValue)
            {
                filter = filter.Where(x => x.Id >= filterModel.FirstId && x.Id <= filterModel.LastId);
            }
            if (filterModel.FirstCreatedDate.HasValue && filterModel.LastCreatedDate.HasValue)
            {
                filter = filter.Where(x =>
                x.CreatedDate.Date >= filterModel.FirstCreatedDate.Value.Date &&
                x.CreatedDate.Date <= filterModel.LastCreatedDate.Value.Date);
            }
            else if (filterModel.FirstCreatedDate.HasValue)
            {
                filter = filter.Where(x => x.CreatedDate.Date >= filterModel.FirstCreatedDate.Value.Date);
            }
            else if (filterModel.LastCreatedDate.HasValue)
            {
                filter = filter.Where(x => x.CreatedDate.Date <= filterModel.LastCreatedDate.Value.Date);
            }
            if (filterModel.FirstUpdatedDate.HasValue && filterModel.LastUpdatedDate.HasValue)
            {
                filter = filter.Where(x =>
                x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date >= filterModel.FirstUpdatedDate.Value.Date &&
               x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date <= filterModel.LastUpdatedDate.Value.Date);
            }
            else if (filterModel.FirstUpdatedDate.HasValue)
            {
                filter = filter.Where(x => x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date >= filterModel.FirstUpdatedDate.Value.Date);
            }
            else if (filterModel.LastUpdatedDate.HasValue)
            {
                filter = filter.Where(x => x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date <= filterModel.LastUpdatedDate.Value.Date);
            }
            if (filterModel.Status.HasValue)
            {
                filter = filter.Where(x => x.Status == filterModel.Status.Value);
            }
            if (filterModel.IsUpdated.HasValue)
            {
                filter = filter.Where(x => x.IsUpdated == filterModel.IsUpdated.Value);
            }
            if (filterModel.Descending == true)
                filter = filter.OrderByDescending(x => x.Id);

            return filter;
        }
        public IQueryable<TEntity> GetAllActives()
        {
            return _dbset;
        }
        public async Task<TEntity> GetByIdAsync(int? Id, CancellationToken token)
        {
            return await _dbset.FindAsync(Id, token);
        }
        public async Task CreateAsync(TEntity entity, CancellationToken token)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync(token);
        }
        public async Task CreateRangeAsync(List<TEntity> entities, CancellationToken token)
        {
            await _dbset.AddRangeAsync(entities);
            await _context.SaveChangesAsync(token);
        }
        public async Task Update(TEntity entity, CancellationToken token)
        {

            _dbset.Update(entity);
            await _context.SaveChangesAsync(token);
            #region Stack OverFlow neden UpdateAsync() yok!!
            /*
               Veri Güncelleme İhtiyacı ve Veri Boyutu: Bir veriyi güncellemek genellikle tek bir işlem olduğundan ve bellekteki bir nesneyi güncellemek çok hızlı gerçekleştiği için asenkron bir işleme gerek yoktur. Yani, güncelleme işlemi bellekte gerçekleşir ve bu işlem veritabanına yansıtılması için SaveChangesAsync gerekir.

            CreateAsync ve DeleteAsync metodlarının asenkron versiyonlarının olmasının nedeni, bu işlemlerin veritabanı üzerinde IO-bound (giriş-çıkış odaklı) operasyonlar olmasından kaynaklanmaktadır. Update işlemi ise çoğunlukla bellekteki nesneleri değiştirme ile sınırlı kaldığı için, bu tür işlemler genellikle senkron olarak yapılabilir. Ancak veritabanına veri eklemek veya silmek gibi.

            !!Asenkron işlemler özellikle I/O Bound ve veritabanı işlemleri gibi zaman alabilen işlemlerde önemli.
            Update işlemi bellekte gerçekleşen bir işlem olduğu için zaten çok hızlı(kendi içinde gerçekleşiyor) dolayısıyla update metodunun create ve delete gibi (doğrudan veritabanına müdahale eden) asenkron filterModeli bulunmuyor.
              */
            #endregion
        }
        public async Task UpdateRangeAsync(List<TEntity> entities, CancellationToken token)
        {
            _dbset.UpdateRange(entities);
            await _context.SaveChangesAsync(token);
        }
        public async Task DeleteAsync(TEntity entity, CancellationToken token)
        {
            entity.Status = DataStatus.Passive;
            await _context.SaveChangesAsync(token);
        }
        public async Task DeleteRangeAsync(List<TEntity> values, CancellationToken token)
        {
            foreach (TEntity entity in values)
            {
                entity.Status = DataStatus.Passive;
            }
            await _context.SaveChangesAsync(token);
        }
        public async Task DestroyAsync(TEntity entity, CancellationToken token)
        {
            _dbset.Remove(entity);
            await _context.SaveChangesAsync(token);
        }
        public async Task DestroyRangeAsync(List<TEntity> entities, CancellationToken token)
        {
            _dbset.RemoveRange(entities);
            await _context.SaveChangesAsync(token);
        }
    }
}
