using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Companies.Suppliers;

namespace DataAccess.Entities.Models.Employees
{
    public class ContractEmployee:BaseEmployeeModel
    {
        public DriverLicense? DriverLicense { get; set; }
        public Language? Language { get; set; }
        public int? SupplierId { get; set; }
        public virtual SubContractWorkerSupplier? SubContractWorkerSupplier { get; set; }
    }
}
