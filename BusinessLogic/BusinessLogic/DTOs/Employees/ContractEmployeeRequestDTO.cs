using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Companies.Suppliers;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Employees
{
    public class ContractEmployeeRequestDTO : BaseEmployeeRequestDTO
    {
        public DriverLicense? DriverLicense { get; set; }
        public Language? Language { get; set; }
        public int? SupplierId { get; set; }//Nav property
    }
}
