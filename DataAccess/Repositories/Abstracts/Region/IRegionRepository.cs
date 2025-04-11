using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts.Region
{
    public interface IRegionRepository<T> : IRepository<T> where T : BaseRegionModel
    {
        IQueryable<T> GetByDistrictName(string districtName);
        IQueryable<T> GetByArrivalTimeDesc();
        IQueryable<T> GetByTransportType(VehicleType type);
    }
}
