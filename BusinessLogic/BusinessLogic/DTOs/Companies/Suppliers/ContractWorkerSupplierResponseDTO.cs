using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Employees;

namespace BusinessLogic.DTOs.Companies.Suppliers
{
    public class ContractWorkerSupplierResponseDTO:BaseResponseModelDTO
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public List<ContractEmployeeResponseDTO>? ContractEmployeeResponseDTOs { get; set; }
    }
}
