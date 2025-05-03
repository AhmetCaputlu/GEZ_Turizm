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

        public IQueryable<ServiceRegion> GetDynamicRegionFilter(string? districtName = null, bool? descendingArrivalDate = null, VehicleType? vehicleType = null, bool? descending = null)
        {
            IQueryable<ServiceRegion> filter = _context.ServiceRegions;
            if (!string.IsNullOrEmpty(districtName))
            {
                filter = filter.Where(x => x.DistrictName.ToLower().Contains(districtName.ToLower()));
            }
            if (descendingArrivalDate == true)
            {
                filter = filter.OrderBy(x => x.ArrivalTime);//En yakınından en uzağına
            }
            else if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
