using Bogus;
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
                    CreatedIPAddress = $"CreatedIPAdress {i}",
                    Status = RandomEnum.GetRandomStatus(),
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    Gender = RandomEnum.GetRandomGender(),
                    BirthDate = RandomDatetime.GetEmployeeBirthDateTime(),
                    Address = $"Adress {i}",
                    PhotoPath = $"PhotoPath {i}",
                    PhoneNumber = faker.Phone.PhoneNumber("05#########"),
                    Email = faker.Internet.Email(),
                    TCN_Passport = $"TCN {i}",
                    HireDate = RandomDatetime.GetDateTime(),
                    Experience = RandomNavId.GetNavIdMax10(),
                    CurrentPosition = RandomEnum.GetRandomDepartment(),
                    CountryId = RandomNavId.GetNavIdMax10()
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}