using DataAccess.Entities.Models.Countries;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Countries
{
    internal class CountrySeedData
    {
        internal static List<Country> GetCountries(int count)
        {
            List<Country> countries = new List<Country>();
            for (int i = 0; i < count; i++)
            {
               
                Country country = new Country
                {

                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),//Başlangıç verilerimiz rastgele olsun
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = $"CreatedIPAdress {i}",
                    Status = RandomEnum.GetRandomStatus(),
                    CountryName = $"CountryName {i}",
                    CountryCode = $"X {i}",
                    CountryDescription = $"CountryDescription {i}",
                    CountryPhone = $"Cphone {i}",
                    Continent = RandomEnum.GetRandomContinent(),  
                };
              
                countries.Add(country);
            }
            return countries;
        }
    }
}
