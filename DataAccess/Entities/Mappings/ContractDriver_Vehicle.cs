using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Mappings
{
    public class ContractDriver_Vehicle
    {
        public int? ContractDriverId { get; set; }
        public virtual ContractDriver? ContractDriver { get; set; }
        public int? VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
