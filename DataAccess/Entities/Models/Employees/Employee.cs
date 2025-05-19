using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Entities.Models.Employees
{
    public class Employee : BaseEmployeeModel
    {
        public int? ContractCount
        {
            get { return (int?)(DateTime.Now.Year - HireDate.Year) / 3 + 1; }
            set { }
        }
        public override DateTime? EndContract
        {
            get
            {
                DateTime endContract = HireDate.AddYears((ContractCount ?? 1) * 3);
                if (endContract.Date > DateTime.Now.Date) { endContract.AddYears(3); }
                return endContract;
            }
        }
        public ushort? DaysWorked { get { return (ushort)(DateTime.Now - HireDate).TotalDays; } set { } }
        public Department CurrentPosition { get; set; }
        //Mapping

        //Country
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }
        //Activity
        public virtual ICollection<ActivityTicketOrder>? ActivityTicketOrders { get; set; }
    }
}
