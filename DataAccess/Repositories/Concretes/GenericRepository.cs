﻿using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using EFCore.BulkExtensions;
namespace DataAccess.Repositories.Concretes

{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericRepository(GezTurizmContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
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
        public IQueryable<T> GetDynamicFilteredEntities(
            int? firstId = null,
            int? lastId = null,
            DateTime? firstCreatedDate = null,
            DateTime? secondCreatedDate = null,
            DateTime? firstUpdatedDate = null,
            DateTime? secondUpdatedDate = null,
            DataStatus? status = null,
            bool? isUpdated = null,
            bool? descending = null
            )
        {
            IQueryable<T> filter = _dbset;
            if (firstId.HasValue && lastId.HasValue)
            {
                filter = filter.Where(x => x.Id >= firstId && x.Id <= lastId);
            }
            if (firstCreatedDate.HasValue && secondCreatedDate.HasValue)
            {
                filter = filter.Where(x =>
                x.CreatedDate.Date >= firstCreatedDate.Value.Date &&
                x.CreatedDate.Date <= secondCreatedDate.Value.Date);
            }
            else if (firstCreatedDate.HasValue)
            {
                filter = filter.Where(x => x.CreatedDate.Date == firstCreatedDate.Value.Date);
            }
            else if (secondCreatedDate.HasValue)
            {
                filter = filter.Where(x => x.CreatedDate.Date == secondCreatedDate.Value.Date);
            }
            if (firstUpdatedDate.HasValue && secondUpdatedDate.HasValue)
            {
                filter = filter.Where(x =>
                x.UpdatedDate.Value.Date >= firstUpdatedDate.Value.Date &&
                x.UpdatedDate.Value.Date <= secondUpdatedDate.Value.Date);
            }
            else if (firstUpdatedDate.HasValue)
            {
                filter = filter.Where(x => x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date == firstUpdatedDate.Value.Date);
            }
            else if (secondUpdatedDate.HasValue)
            {
                filter = filter.Where(x => x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date == secondUpdatedDate.Value.Date);
            }
            if (status.HasValue)
            {
                filter = filter.Where(x => x.Status == status.Value);
            }
            if (isUpdated.HasValue)
            {
                filter = filter.Where(x => x.IsUpdated == isUpdated.Value);
            }
            if (descending == true)
                filter = filter.OrderByDescending(x => x.Id);

            return filter;
        }
        public async Task<T?> GetByIdAsync(int? Id)
        {
            return await _dbset.FindAsync(Id);
        }
        public async Task CreateAsync(T entity)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task CreateRangeAsync(List<T> entities)
        {
            await _dbset.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }
        public async Task CreateBulkAsync(List<T> values)
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
        public async Task UpdateRangeAsync(List<T> entities)
        {
            _dbset.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateBulkAsync(List<T> values)
        {
            await _context.BulkUpdateAsync(values);
        }
        public async Task DeleteAsync(int Id)
        {
            T entity = await _dbset.FindAsync(Id);
            entity.Status = DataStatus.Passive;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteRangeAsync(List<T> values)
        {
            foreach (T entity in values)
            {
                entity.Status = DataStatus.Passive;
            }
            await _context.SaveChangesAsync();
        }
        public async Task DeleteRangeSelectAsync(int first, int last)
        {
            var deletedItems = _dbset.Where(x => x.Id > first && x.Id < last);
            #region Uyarı!!
            /*I_dbsetable sadece bir sorgu nesnesi oluşturur.Herhangi bir veritabanı işleminde bulunmadığı için await kullanımı hata verir.Tolistasync gibi bir metod ile bu sorgu veritabanından verileri bir Lİst<T> olarak geri döner.Bu noktada await kullanılır.*/
            #endregion
            foreach (var deletedItem in deletedItems)
            {
                deletedItem.Status = DataStatus.Passive;
            }
            await _context.SaveChangesAsync();
        }
        public async Task DestroyAsync(int Id)
        {
            T entity = await _dbset.FindAsync(Id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DestroyRangeAsync(List<T> entities)
        {
            _dbset.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }
        public async Task DestroyRangeSelectAsync(int first, int last)
        {
            var values = _dbset.Where(x => x.Id > first && x.Id < last);
            _context.RemoveRange(values);
            await _context.SaveChangesAsync();
        }
        public async Task DestroyBulkAsync(List<T> values)
        {
            await _context.BulkDeleteAsync(values);
        }
    }
}
