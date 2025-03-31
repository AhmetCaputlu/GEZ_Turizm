using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Tickets;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Tickets
{
    internal class TourTicketSeedData
    {
        internal static List<TourTicket> GetTourTickets(int count)
        {
            List<TourTicket> tourTickets = new List<TourTicket>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                TourTicket ticket = new TourTicket
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    TicketName = faker.Name.FullName(),
                    SeatNumber = faker.Random.Char('A', 'D').ToString() + faker.Random.Byte(1,255),
                    DepartureAdress = faker.Random.Words(2),
                    DestinationAdress = faker.Random.Words(2),
                    DepartureDate = RandomDatetime.GetDateTime(),
                    Price = faker.Random.Decimal(100,420),
                    DiscountRate = faker.Random.Byte(10,20),//Vip gibi indirim alıyorlar
                    Currency = RandomEnum.GetRandomCurrency(),
                    PaymentStatus = RandomEnum.GetRandomPaymentStatus(),
                    TourId = RandomNavId.GetNavIdMax5(),
                };
                ticket.ArrivalDate = ticket.DepartureDate.AddHours(7);
                tourTickets.Add(ticket);
            }
            return tourTickets;
        }
    }
}
