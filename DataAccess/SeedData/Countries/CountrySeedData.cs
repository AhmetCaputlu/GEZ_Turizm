using Bogus;
using DataAccess.Entities.Models.Countries;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Countries
{
    internal class CountrySeedData
    {
        internal static List<Country> GetCountries(int count)
        {
            Faker faker = new Faker();
            List<Country> countries = new List<Country>();
            string[] countryNames = { "Turkey", "Russia", "United States of America", "Kingdom of Saudi Arabia", "Germany" };
            string[] countryCode = { "TR", "RU", "USA", "SA", "GER" };
            string[] countryNumber = { "+90", "+7", "+1", "+966", "+49" };
            for (int i = 0; i < count; i++)
            {
                
                Country country = new Country
                {

                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),//Başlangıç verilerimiz rastgele olsun
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    CountryName = countryNames[i],
                    CountryCode = countryCode[i],
                    CountryDescription = faker.Lorem.Sentence(6),
                    CountryPhone = countryNumber[i],
                    Continent = RandomEnum.GetRandomContinent(),  //Uyuşmazlık
                };
              
                countries.Add(country);
            }
            return countries;
        }
    }
}
