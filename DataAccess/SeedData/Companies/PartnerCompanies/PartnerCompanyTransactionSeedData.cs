﻿using Bogus;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Companies.PartnerCompanies
{
    internal class PartnerCompanyTransactionSeedData
    {
        internal static List<PartnerCompanyTransaction> GetPartnerCompanyTransactions(int count)
        {
            List<PartnerCompanyTransaction> partnerCompanyTransactions = new List<PartnerCompanyTransaction>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                PartnerCompanyTransaction partnerCompanyTransaction = new PartnerCompanyTransaction
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    Type = RandomEnum.GetRandomTransactionType(),
                    TotalCost = faker.Random.Decimal(1000, 15000),
                    PartnerCompanyId = faker.Random.Int(1, 5)
                };
                partnerCompanyTransactions.Add(partnerCompanyTransaction);
            }
            return partnerCompanyTransactions;
        }
    }
}

