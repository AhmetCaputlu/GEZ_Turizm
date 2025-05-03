using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Repositories.Abstracts.Region
{
    public interface IGenericRegionRepository : IGenericRepository<ServiceRegion>
    {
        IQueryable<ServiceRegion> GetDynamicRegionFilter(string? districtName = null, bool? descendingArrivalDate = null, VehicleType? vehicleType = null, bool? descending = null);
    }
}
