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
        public IQueryable<T> GetVehicleByVehicleType(VehicleType vehicleType)
        {
            return _dbset.Where(x => x.VehicleType == vehicleType);
        }
        public IQueryable<T> GetVehicleByLicensePlate(string licensePlate)
        {
            return _dbset.Where(x => x.LicensePlate.ToLower().Contains(licensePlate.ToLower()));
        }
        public IQueryable<T> GetVehicleByModel(string model)
        {
            return _dbset.Where(x => x.Model.ToLower().Contains(model.ToLower()));
        }
        public IQueryable<T> GetVehicleByKilometerDesc()
        {
            return _dbset.OrderByDescending(x => x.Kilometer);
        }
        public IQueryable<T> GetVehicleByAgeDesc()
        {
            return _dbset.OrderByDescending(x => x.Age);

        }
        public IQueryable<T> GetVehicleByCapacityDesc()
        {
            return _dbset.OrderByDescending(x => x.Capacity);
        }

        public IQueryable<T> GetVehiclesByAvailable(bool value)
        {
            return _dbset.Where(x => x.IsAvailable == value);
        }
    }
}
