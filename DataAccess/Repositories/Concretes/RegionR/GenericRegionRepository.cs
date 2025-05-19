using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;
using DataAccess.Repositories.Abstracts.Region;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Region
{
    public class GenericRegionRepository : GenericRepository<ServiceRegion, RegionFilterModel>, IGenericRegionRepository
    {
        private readonly GezTurizmContext _context;
        public GenericRegionRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<ServiceRegion> GetDynamicFilteredEntities(RegionFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (!string.IsNullOrEmpty(filterModel.DistrictName))
            {
                filter = filter.Where(x => x.DistrictName.ToLower().Contains(filterModel.DistrictName.ToLower()));
            }
            if (filterModel.VehicleType.HasValue)
            {
                filter = filter.Where(x => x.TransportVehicle == filterModel.VehicleType);
            }
            if (filterModel.Descending != true && filterModel.DescendingByArrivalTime == true)
            {
                filter = filter.OrderBy(x => x.ArrivalTime);//En yakınından en uzağına
            }
            return filter;
        }
    }
}
