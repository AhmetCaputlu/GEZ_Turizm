using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.Vehicle;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Vehicle
{
    public class GenericVehicleRepository<T> : GenericRepository<T>, IGenericVehicleRepository<T> where T : BaseVehicleModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericVehicleRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public IQueryable<T> GetDynamicVehicleFilter(VehicleType? vehicleType = null, string? licensePlate = null, string? model = null, bool? available = null, bool? descending = null)
        {
            IQueryable<T> filter = _dbset;
            if (vehicleType.HasValue)
            {
                filter = filter.Where(x => x.VehicleType == vehicleType.Value);
            }
            if (!string.IsNullOrEmpty(licensePlate))
            {
                filter = filter.Where(x => x.LicensePlate.ToLower().Contains(licensePlate.ToLower()));
            }
            if (!string.IsNullOrEmpty(model))
            {
                filter = filter.Where(x => x.Model.ToLower().Contains(model.ToLower()));
            }
            if (available == true)
            {
                filter = filter.Where(x => x.IsAvailable == true);
            }
            if(descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
