using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Employees;

namespace BusinessLogic.DTOs.Companies.Suppliers
{
    public class ContractWorkerSupplierResponseDTO : BaseCompanyResponseDTO
    {
        public List<ContractEmployeeResponseDTO>? ContractEmployeeResponseDTOs { get; set; }
    }
}
