using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Regions;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Employees
{
    public class EmployeeResponseDTO:BaseResponseModelDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte? Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;

                if (BirthDate.Date > today.AddYears(-age))
                {
                    age--;
                }

                return (byte?)age;
            }
        }
        public string? Email { get; set; }
        public string? TCN_Passport { get; set; }
        public DateTime HireDate { get; set; }
        public int Experience { get; set; }
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
        public ushort? DaysWorked { get { return (ushort)(DateTime.Now - HireDate).TotalDays; }}
        public Department CurrentPosition { get; set; }
        public CountryResponseDTO? CountryResponseDTO { get; set; }

    }
}
