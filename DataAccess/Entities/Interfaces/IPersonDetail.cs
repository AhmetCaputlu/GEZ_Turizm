using System.Reflection;
using DataAccess.Entities.Enums;

namespace DataAccess.Entities.Interfaces
{
    public interface IPersonDetail
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        byte Age { get; }

        string? Address { get; set; }
        string? PhotoPath { get; set; }
        string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TCN_Passport { get; set; }
    }
}
