using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Employees;

namespace DataAccess.Entities.Models.Companies.Suppliers
{
    public class SubContractWorkerSupplier:BaseCompanyModel
    {
        //Mapping
        public virtual ICollection<ContractEmployee>? ContractEmployees { get; set; }

    }
}
