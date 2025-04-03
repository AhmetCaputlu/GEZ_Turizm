using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using EFCore.BulkExtensions;
using DataAccess.Entities.Models.WebUsers;
namespace DataAccess.Repositories.Concretes

{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public Repository(GezTurizmContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public IQueryable<T> GetAllEntities()
        {
            return _dbset;

        }
        public IQueryable<T> GetAllActives()
        {
            return _dbset.Where(x => x.Status == DataStatus.Active);
        }
        public IQueryable<T> GetAllPassives()
        {
            return _dbset.Where(x => x.Status == DataStatus.Passive);
        }
        public IQueryable<T> GetAllUnknowns()
        {
            return _dbset.Where(x => x.Status == DataStatus.Unknown);
        }
        public IQueryable<T> GetAllUpdated()
        {
            return _dbset.Where(x => x.IsUpdated == true);
        }
        public IQueryable<T> GetAllNotUpdated()
        {
            return _dbset.Where(x => x.IsUpdated == false);
        }
#nullable disable
        public async Task<T> GetByIdAsync(int Id)
        {
            return await _dbset.FindAsync(Id);
        }
        public IQueryable<T> GetEntitiesByCreatedDate(DateTime dateTime)
        {
            return _dbset.Where(x => x.CreatedDate.Date == dateTime.Date);
        }
        public IQueryable<T> GetEntitiesByUpdatedDate(DateTime dateTime)
        {
            return _dbset.Where(x => x.UpdatedDate.Value.Date == dateTime.Date);
        }
        public IQueryable<T> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate)
        {
            return _dbset.Where(x => x.CreatedDate.Date >= firstDate.Date && x.CreatedDate.Date <= lastDate.Date);
        }
        public IQueryable<T> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate)
        {
            return _dbset.Where(x => x.UpdatedDate.Value.Date >= firstDate.Date &&
            x.UpdatedDate.Value.Date <= lastDate.Date);
        }
        public async Task CreateAsync(T entity)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task CreateRangeAsync(IEnumerable<T> entities)
        {
            await _dbset.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }
        public async Task CreateBulkAsync(IEnumerable<T> values)
        {
            await _context.BulkInsertAsync(values);//Direkt SQL kaydı yapıyor
        }
        public async Task Update(T entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();
            #region Stack OverFlow neden UpdateAsync() yok!!
            /*
               Veri Güncelleme İhtiyacı ve Veri Boyutu: Bir veriyi güncellemek genellikle tek bir işlem olduğundan ve bellekteki bir nesneyi güncellemek çok hızlı gerçekleştiği için asenkron bir işleme gerek yoktur. Yani, güncelleme işlemi bellekte gerçekleşir ve bu işlem veritabanına yansıtılması için SaveChangesAsync gerekir.

            CreateAsync ve DeleteAsync metodlarının asenkron versiyonlarının olmasının nedeni, bu işlemlerin veritabanı üzerinde IO-bound (giriş-çıkış odaklı) operasyonlar olmasından kaynaklanmaktadır. Update işlemi ise çoğunlukla bellekteki nesneleri değiştirme ile sınırlı kaldığı için, bu tür işlemler genellikle senkron olarak yapılabilir. Ancak veritabanına veri eklemek veya silmek gibi.

            !!Asenkron işlemler özellikle I/O Bound ve veritabanı işlemleri gibi zaman alabilen işlemlerde önemli.
            Update işlemi bellekte gerçekleşen bir işlem olduğu için zaten çok hızlı(kendi içinde gerçekleşiyor) dolayısıyla update metodunun create ve delete gibi (doğrudan veritabanına müdahale eden) asenkron modeli bulunmuyor.
              */
            #endregion
        }
        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            _dbset.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateBulkAsync(IEnumerable<T> values)
        {
            await _context.BulkUpdateAsync(values);
        }
        public async Task DeleteAsync(int Id)
        {
            T entity = await _dbset.FindAsync(Id);
            entity.Status = DataStatus.Passive;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                entity.Status = DataStatus.Passive;
            }
            await _context.SaveChangesAsync();
        }
        public async Task DestroyAsync(int Id)
        {
            T entity = await _dbset.FindAsync(Id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DestroyRangeAsync(IEnumerable<T> entities)
        {
            _dbset.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }
        public async Task DestroyBulkAsync(IEnumerable<T> values)
        {
            await _context.BulkDeleteAsync(values);
        }
    }
}
