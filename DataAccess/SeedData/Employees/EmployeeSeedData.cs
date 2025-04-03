using Bogus;
using Bogus.Extensions.UnitedKingdom;
using DataAccess.Entities.Models.Employees;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Employees
{
    internal class EmployeeSeedData
    {
        internal static List<Employee> GetEmployees(int count)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < count; i++)
            {
                Faker faker = new Faker();
                Employee employee = new Employee
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    Gender = RandomEnum.GetRandomGender(),
                    BirthDate = RandomDatetime.GetEmployeeBirthDateTime(),
                    Address = faker.Address.CountryOfUnitedKingdom(),
                    PhotoPath = faker.Internet.UrlWithPath(),
                    PhoneNumber = faker.Phone.PhoneNumber("05#########"),
                    Email = faker.Internet.Email(),
                    TCN_Passport = faker.Random.ReplaceNumbers("###########"),
                    HireDate = RandomDatetime.GetDateTime(),
                    Experience = RandomNavId.GetNavIdMax5(),
                    CurrentPosition = RandomEnum.GetRandomDepartment(),
                    CountryId = RandomNavId.GetNavIdMax5(),
                    ResidenceRegionId = RandomNavId.GetNavIdMax5()
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}