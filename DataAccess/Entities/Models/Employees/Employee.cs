using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Countries;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Tickets;

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
        //TourTicketOrder
        public virtual ICollection<TourTicketOrder>? TourTicketOrders { get; set; }



    }
}
