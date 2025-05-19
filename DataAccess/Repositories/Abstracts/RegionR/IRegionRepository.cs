using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Repositories.Abstracts.Region
{
    public interface IRegionRepository : IGenericRepository<ServiceRegion,RegionFilterModel>
    {

    }
}
