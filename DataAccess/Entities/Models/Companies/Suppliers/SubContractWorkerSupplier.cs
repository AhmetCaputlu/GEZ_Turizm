using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Employees;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities.Models.Companies.Suppliers
{
    public class SubContractWorkerSupplier:BaseCompanyModel
    {
        //Mapping
        public virtual ICollection<ContractDriver>? ContractDrivers { get; set; }
        public virtual ICollection<ContractTourGuide>? ContractTourGuides { get; set; }
    }
}
