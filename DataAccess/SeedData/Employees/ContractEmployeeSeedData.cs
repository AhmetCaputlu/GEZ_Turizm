﻿using Bogus;
using Bogus.Extensions.UnitedKingdom;
using DataAccess.Entities.Models.Employees;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Employees
{
    internal class ContractEmployeeSeedData
    {
        internal static List<ContractEmployee> GetContractEmployees(int count)
        {
            List<ContractEmployee> contractEmployees = new List<ContractEmployee>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ContractEmployee ContractEmployee = new ContractEmployee
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
                    Experience = faker.Random.Int(1, 5),
                    DriverLicense = RandomEnum.GetRandomDriverLicense(),
                    Language = RandomEnum.GetRandomLanguage(),
                    SupplierId = faker.Random.Int(1, 5)
                };
                contractEmployees.Add(ContractEmployee);
            }
            return contractEmployees;
        }
    }
}