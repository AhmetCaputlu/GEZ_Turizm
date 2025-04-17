using DataAccess.Entities.Abstracts;

namespace DataAccess.Entities.Models.Vehicles
{
    public class Vehicle : BaseVehicleModel
    {
        public DateTime PurchaseDate { get; set; }
        public decimal MarketValue { get; set; }
    }
}
