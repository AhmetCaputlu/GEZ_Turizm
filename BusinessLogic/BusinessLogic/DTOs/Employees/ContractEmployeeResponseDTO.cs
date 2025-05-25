using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Companies.Suppliers;
using DataAccess.Entities.Models.Companies.Suppliers;

namespace BusinessLogic.DTOs.Employees
{
    public class ContractEmployeeResponseDTO : BaseEmployeeResponseDTO
    {
        public virtual ContractWorkerSupplierResponseDTO? ContractWorkerSupplierResponseDTO { get; set; }
    }
}
