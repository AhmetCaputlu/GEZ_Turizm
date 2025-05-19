using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Regions
{
    public class CountryFilterModel:BaseFilterModel
    {
        public Continent? Continent { get; set; } = null;
    }
}
