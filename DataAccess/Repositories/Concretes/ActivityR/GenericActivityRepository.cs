using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using DataAccess.Repositories.Abstracts.Activity;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace DataAccess.Repositories.Concretes.Activity
{
    public class GenericActivityRepository<T> : GenericRepository<T>, IGenericActivityRepository<T> 
        where T : BaseActivityModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericActivityRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> SearchByActivityName(string activityName)
        {
            var selectedItems = _dbset.Where(x => x.EventName.ToLower().Contains(activityName.ToLower()));
            return selectedItems;
        }

        public IQueryable<T> GetActivitiesByStartDate(DateTime dateTime)
        {
            var selectedItems = _dbset.Where(x => x.StartDate.Date == dateTime.Date);
            return selectedItems;
        }

        public IQueryable<T> SearchActivityByDescription(string description)
        {
            var selectedItems = _dbset.Where(x => x.Description.ToLower().Contains(description.ToLower()));
            return selectedItems;
        }

        public IQueryable<T> SearchActivityByRegionId(int regionId)
        {
            var selectedItems = _dbset.Where(x => x.RegionId == regionId);
            return selectedItems;
        }
    }
}
