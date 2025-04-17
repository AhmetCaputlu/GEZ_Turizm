using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Repositories.Abstracts.Region
{
    public interface IGenericRegionRepository : IGenericRepository<ServiceRegion>
    {
        IQueryable<ServiceRegion> GetByDistrictName(string districtName);
        IQueryable<ServiceRegion> GetByArrivalTimeDesc();
        IQueryable<ServiceRegion> GetByTransportType(VehicleType type);
    }
}
