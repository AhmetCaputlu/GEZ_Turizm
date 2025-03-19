using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Mappings
{
    public class ContractDriver_RentalVehicle
    {
        public int ContactDriverId { get; set; }
        public ContractDriver ContractDriver { get; set; }
        public int RentalVehicleId { get; set; }
        public RentalVehicle RentalVehicle { get; set; }
    }
}
