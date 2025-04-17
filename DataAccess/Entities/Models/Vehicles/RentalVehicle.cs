using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Companies.Suppliers;

namespace DataAccess.Entities.Models.Vehicles
{
    public class RentalVehicle:BaseVehicleModel
    {
        public decimal DailyRentalFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int TotalRentalDay { get { return (ExpireDate - StartDate).Days; } set { } }
        public decimal TotalPrice { get { return DailyRentalFee * TotalRentalDay; } set { } }
        //Mapping
        public int? RentalVehicleSupplierId { get; set; }
        public virtual RentalVehicleSupplier? RentalVehicleSupplier { get; set; }
        //TourTicket
    }
}
