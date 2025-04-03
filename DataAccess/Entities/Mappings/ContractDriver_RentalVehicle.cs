using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Mappings
{
    public class ContractDriver_RentalVehicle
    {
        public int? ContractDriverId { get; set; }
        public virtual ContractDriver? ContractDriver { get; set; }
        public int? RentalVehicleId { get; set; }
        public virtual RentalVehicle? RentalVehicle { get; set; }
    }
}
