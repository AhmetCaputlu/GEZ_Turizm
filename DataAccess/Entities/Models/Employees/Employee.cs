using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Countries;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Entities.Models.Employees
{
    public class Employee : BaseEmployeeModel
    {
        public override DateTime EndContract { get { return HireDate.AddYears(3); } }
        public ushort DaysWorked { get { return (ushort)(DateTime.Now - HireDate).TotalDays; } }
        public Department CurrentPosition { get; set; }
        //Mapping

        //Country
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }

        //Residence Region
        public int? ResidenceRegionId { get; set; }
        public ResidenceRegion? ResidenceRegion { get; set; }

        
    }
}
