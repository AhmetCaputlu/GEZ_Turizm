using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Models.WebUsers
{
    public class WebUserProfile : IPersonDetail, IEntity
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedID { get; set; }
        public string CreatedIPAddress { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedID { get; set; }
        public string? UpdatedIPAddress { get; set; }
        public DataStatus Status { get; set; }
        //Custom
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public byte? Age
        {
            #region Veritabanı bu kodu okuyamadı(EZİK MSSQL)
            /* _age = (byte)(DateTime.Now.Year - BirthDate.Year -
                    (BirthDate.Date > DateTime.Today.AddYears(DateTime.Now.Year - BirthDate.Year) ? 1 : 0));*/
            #endregion

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


        //WebUserAccount
        public int? WebUserAccountId { get; set; }
        public virtual WebUserAccount? WebUserAccount { get; set; }
    }
}
