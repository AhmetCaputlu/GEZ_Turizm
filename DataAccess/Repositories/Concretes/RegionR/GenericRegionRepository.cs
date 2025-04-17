using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Regions;
using DataAccess.Repositories.Abstracts.Region;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Region
{
    public class GenericRegionRepository : GenericRepository<ServiceRegion>, IGenericRegionRepository
    {
        private readonly GezTurizmContext _context;
        public GenericRegionRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<ServiceRegion> GetByDistrictName(string districtName)
        {
            return _context.ServiceRegions.Where(x => x.DistrictName.ToLower().Contains(districtName));
        }

        public IQueryable<ServiceRegion> GetByArrivalTimeDesc()
        {
            return _context.ServiceRegions.OrderBy(x => x.ArrivalTime);
        }

        public IQueryable<ServiceRegion> GetByTransportType(VehicleType type)
        {
            return _context.ServiceRegions.Where(x => x.TransportVehicle == type);
        }
    }
}
