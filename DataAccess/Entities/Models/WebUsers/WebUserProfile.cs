using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Models.WebUsers
{
    public class WebUserProfile : IPersonDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public byte Age
        {
            get
            {
                return (byte)(DateTime.Now.Year - BirthDate.Year -
                  (BirthDate.Date > DateTime.Today.AddYears(DateTime.Now.Year - BirthDate.Year) ? 1 : 0));
            }
        }
        public string? Address { get; set; }
        public string? PhotoPath { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TCN_Passport { get; set; }
        //Custom
        public DateTime UpdatedDate { get; set; }
        //Mapping

        //WebUserAccount
        public int? WebUserAccountId { get; set; }
        public virtual WebUserAccount? WebUserAccount { get; set; }
    }
}
