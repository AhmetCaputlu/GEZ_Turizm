using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Mappings;
using DataAccess.Entities.Models.Companies.Suppliers;

namespace DataAccess.Entities.Models.Employees
{
    public class ContractDriver : BaseEmployeeModel
    {
        public DriverLicense DriverLicense { get; set; }
        //Mapping
        public virtual ICollection<ContractDriver_Vehicle>? ContractDrivers_Vehicles { get; set; }
        public virtual ICollection<ContractDriver_RentalVehicle>? ContractDrivers_RentalVehicles { get; set; }
        public int? SubContractWorkerSupplierId { get; set; }
        public virtual SubContractWorkerSupplier? SubContractWorkerSupplier { get; set; }
    }
}
