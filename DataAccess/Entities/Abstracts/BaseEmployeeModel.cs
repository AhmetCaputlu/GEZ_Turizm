using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseEmployeeModel : BaseModel, IPersonDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
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
            set { }
        }
        public string? Address { get; set; }
        public string? PhotoPath { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TCN_Passport { get; set; }
        //Custom
        public DateTime HireDate { get; set; }
        public virtual DateTime EndContract { get { return HireDate.AddYears(1); } set { } }
        public int Experience { get; set; }
    }
}
