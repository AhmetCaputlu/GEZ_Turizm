using Bogus;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.PassTickets
{
    internal class TourPassTicketSeedData
    {
        internal static List<PassTourTicket> GetPassTourTickets(int count)
        {
            List<PassTourTicket> passTourTickets = new List<PassTourTicket>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                PassTourTicket passTourTicket = new PassTourTicket
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    Price = faker.Random.Decimal(100, 420),                    
                    CommissionRate = faker.Random.Byte(5, 10),
                    PartnerCompanyTransactionId = faker.Random.Int(1,5)
                };
                passTourTickets.Add(passTourTicket);
            }
            return passTourTickets;
        }
    }
}
