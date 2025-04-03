using Bogus;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.PassTickets
{
    internal class EventPassTicketSeedData
    {
        internal static List<PassEventTicket> GetPassEventTickets(int count)
        {
            List<PassEventTicket> passEventTickets = new List<PassEventTicket>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                PassEventTicket passEventTicket = new PassEventTicket
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    Price = faker.Random.Decimal(100, 420),
                    CommissionRate = faker.Random.Byte(5, 20),
                    PartnerCompanyTransactionId = faker.Random.Int(1, 35)
                };
                passEventTickets.Add(passEventTicket);
            }
            return passEventTickets;
        }
    }
}
