using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseEmployeeModel: BaseModel , IPersonDetail
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte Age {get {return (byte)(DateTime.Now.Year - BirthDate.Year -
                (BirthDate.Date > DateTime.Today.AddYears(DateTime.Now.Year - BirthDate.Year) ? 1 : 0));} set { }}
        public string? Address { get; set; }
        public string? PhotoPath { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TCN_Passport { get; set; }
        //Custom
        public DateTime HireDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public virtual DateTime EndContract { get { return HireDate.AddYears(1); } set { } }
        public int Experience { get; set; }
    }
}
