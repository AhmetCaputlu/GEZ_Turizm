using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Regions;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Employees
{
    public class EmployeeResponseDTO : BaseEmployeeResponseDTO
    {
        public int? ContractCount
        {
            get { return (int?)(DateTime.Now.Year - HireDate.Year) / 3 + 1; }
        }
        public DateTime? EndContract
        {
            get
            {
                DateTime endContract = HireDate.AddYears((ContractCount ?? 1) * 3);
                if (endContract.Date > DateTime.Now.Date) { endContract.AddYears(3); }
                return endContract;
            }
        }
        public ushort? DaysWorked { get { return (ushort)(DateTime.Now - HireDate).TotalDays; } }
        public Department CurrentPosition { get; set; }
        public CountryResponseDTO? CountryResponseDTO { get; set; }

    }
}
