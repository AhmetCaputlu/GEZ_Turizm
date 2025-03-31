using Bogus;
using DataAccess.Entities.Models.Tickets;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Tickets
{
    internal class EventTicketSeedData
    {
        internal static List<EventTicket> GetEventTickets(int count)
        {
            List<EventTicket> eventTickets = new List<EventTicket>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                EventTicket ticket = new EventTicket
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    TicketName = faker.Name.FullName(),
                    SeatNumber = faker.Random.Char('A', 'D').ToString() + faker.Random.Byte(1, 255),
                    DepartureAdress = faker.Random.Words(2),
                    DestinationAdress = faker.Random.Words(2),
                    DepartureDate = RandomDatetime.GetDateTime(),
                    Price = faker.Random.Decimal(100, 420),
                    DiscountRate = faker.Random.Byte(10, 20),//şimdilik Vip gibi tanımlansınlar.
                    Currency = RandomEnum.GetRandomCurrency(),
                    PaymentStatus = RandomEnum.GetRandomPaymentStatus(),
                    EventId = RandomNavId.GetNavIdMax5(),
                };
                ticket.ArrivalDate = ticket.DepartureDate.AddHours(3);
                eventTickets.Add(ticket);
            }
            return eventTickets;
        }
    }
}
