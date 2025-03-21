using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Entities.Models.Countries
{
    public class Country : BaseModel
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string? CountryDescription { get; set; }
        public string CountryPhone { get; set; }
        public Continent Continent { get; set; }
        //Mapping

        //WebUSerAcoount
        public virtual ICollection<WebUserAccount>? WebUserAccounts { get; set; }
        //Employee
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
