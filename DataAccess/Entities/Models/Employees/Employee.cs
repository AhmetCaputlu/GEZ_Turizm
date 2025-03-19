using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Entities.Models.Employees
{
    public class Employee : BaseEmployeeModel
    {
        public override DateTime EndContract { get { return HireDate.AddYears(3); } }
        public ushort DaysWorked { get { return (ushort)(DateTime.Now - HireDate).TotalDays; } }
        public Department CurrentPosition { get; set; }
        //Mapping

        //Residence Region
        public int? ResidenceRegionId { get; set; }
        public ResidenceRegion? ResidenceRegion { get; set; }

        //EventTicketOrder
        public virtual ICollection<EventTicketOrder>? EventTicketOrders { get; set; }
        //TourTicketOrder
        public virtual ICollection<TourTicketOrder>? TourTicketOrders { get; set; }
        //Product Order
        public virtual ICollection<ProductOrder>? ProductOrders { get; set; }
    }
}
