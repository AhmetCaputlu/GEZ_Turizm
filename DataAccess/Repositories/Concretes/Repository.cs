using DataAccess.Context;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities.Enums;
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
        #nullable disable
        public async Task<T> GetByIdAsync(int Id)
        {
            return await _dbset.FindAsync(Id);
        }
        public Task<IQueryable<T>> GetEntitiesByCreatedDateAsync(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
        public Task<IQueryable<T>> GetEntitiesByUpdatedDateAsync(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
        public Task<IQueryable<T>> GetEntitiesBetweenCreatedDatesAsync(DateTime firstDate, DateTime lastDate)
        {
            throw new NotImplementedException();
        }
        public Task<IQueryable<T>> GetEntitiesBetweenUpdatedDatesAsync(DateTime firstDate, DateTime lastDate)
        {
            throw new NotImplementedException();
        }
        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public Task CreateRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
        public Task CreateBulkAsync(IEnumerable<T> values)
        {
            throw new NotImplementedException();
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
