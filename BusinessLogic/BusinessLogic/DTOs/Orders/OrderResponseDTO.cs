using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Employees;
using BusinessLogic.DTOs.WebUser;

namespace BusinessLogic.DTOs.Orders
{
    public class OrderResponseDTO:BaseResponseModelDTO
    {
        public string? Note { get; set; }
        public WebUserAccountResponseDTO? WebUserAccountResponseDTO { get; set; }
        public EmployeeResponseDTO? EmployeeResponseDTO { get; set; }
    }
}
