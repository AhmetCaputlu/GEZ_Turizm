﻿using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.OrderDetail;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.OrderDetail
{
    public class OrderDetailRepository<T> : IOrderDetailRepository<T> where T : BaseOrderDetailModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public OrderDetailRepository(GezTurizmContext context)
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
        public IQueryable<T> GetEntitiesBetweenId(int firstId, int lastId)
        {
            return _dbset.Where(x => x.Id >= firstId && x.Id <= lastId);
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

        public IQueryable<T> GetDetailByUnitPriceDesc()
        {
            return _dbset.OrderByDescending(x => x.UnitPrice);
        }

        public IQueryable<T> GetDetailByQuantityDesc()
        {
            return _dbset.OrderByDescending(x => x.Quantity);
        }

        public IQueryable<T> GetTotalCostRange(decimal low, decimal high)
        {
            return _dbset.Where(x => x.UnitPrice <= high && x.UnitPrice >= low);
        }
    }
}
