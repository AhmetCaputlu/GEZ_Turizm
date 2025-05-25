using DataAccess.Context;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Repositories.RegionR
{
    public class RegionRepository : GenericRepository<ServiceRegion, RegionFilterModel>, IRegionRepository
    {
        private readonly GezTurizmContext _context;
        public RegionRepository(GezTurizmContext context) : base(context)
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
