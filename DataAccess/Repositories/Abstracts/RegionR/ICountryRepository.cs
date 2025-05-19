using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Repositories.Abstracts.RegionR//Sınıf adı ile çakışma yaşadığı için sonunu ikiledim
{
    public interface ICountryRepository : IGenericRepository<Country,CountryFilterModel>
    {

    }
}
