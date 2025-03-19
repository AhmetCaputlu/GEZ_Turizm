using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Mappings;
using DataAccess.Entities.Models.Companies.Suppliers;

namespace DataAccess.Entities.Models.Employees
{
    public class ContractTourGuide:BaseEmployeeModel
    {
        public Language Language { get; set; }
        //Mapping
        public virtual ICollection<ContractTourGuide_ServiceRegion>? ContractTourGuides_ServiceRegions { get; set; }
        public int? SubContractWorkerSupplierId { get; set; }
        public virtual SubContractWorkerSupplier? SubContractWorkerSupplier { get; set; }
    }
}
