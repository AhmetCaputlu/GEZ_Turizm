using BusinessLogic.DTOs.Regions;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;

namespace BusinessLogic.Services.RegionS
{
    public interface ICountryService : IGenericService<Country, CountryResponseDTO, CountryRequestDTO, CountryFilterModel>
    {
    }
}
