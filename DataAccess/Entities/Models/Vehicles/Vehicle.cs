using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Mappings;
using DataAccess.Entities.Models.Employees;

namespace DataAccess.Entities.Models.Vehicles
{
    public class Vehicle :BaseVehicleModel
    {
        public DateTime PurchaseDate { get; set; }
        public decimal MarketValue { get; set; }
        //Mapping
        public virtual ICollection<ContractDriver_Vehicle>? ContractDrivers_Vehicles { get; set; }
        
    }
}
