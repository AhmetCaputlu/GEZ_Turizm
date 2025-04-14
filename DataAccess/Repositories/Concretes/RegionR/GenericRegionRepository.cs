using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.Region;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Region
{
    public class GenericRegionRepository<T> : GenericRepository<T>, IGenericRegionRepository<T> where T : BaseRegionModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericRegionRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> GetByDistrictName(string districtName)
        {
            return _dbset.Where(x => x.DistrictName.ToLower().Contains(districtName));
        }

        public IQueryable<T> GetByArrivalTimeDesc()
        {
            return _dbset.OrderBy(x => x.ArrivalTime);
        }

        public IQueryable<T> GetByTransportType(VehicleType type)
        {
            return _dbset.Where(x => x.TransportVehicle == type);
        }
    }
}
