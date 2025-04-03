using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using EFCore.BulkExtensions;
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
            await _context.BulkInsertAsync(values);
        }
        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
        public Task UpdateBulkAsync(IEnumerable<T> values)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
        public Task DeleteBulkAsync(IEnumerable<T> values)
        {
            throw new NotImplementedException();
        }
        public Task DestroyAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public Task DestroyRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
        public Task DestroyBulkRangeAsync(IEnumerable<T> values)
        {
            throw new NotImplementedException();
        }
    }
}
