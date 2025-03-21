using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Products;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseTicketModel:BaseModel
    {
        public string TicketName { get; set; }
        public string SeatNumber { get; set; }  
        public string DepartureAdress { get; set; }  
        public string DestinationAdress { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }  
        public decimal Price { get; set; }  
        public byte DiscountRate { get; set; }//VIP Users  
        public Currency Currency { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
