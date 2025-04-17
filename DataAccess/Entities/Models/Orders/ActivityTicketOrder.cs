using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Entities.Models.Orders
{
    public class ActivityTicketOrder : BaseModel
    {
        public string? Note { get; set; }
        public string WebUserEmail { get; set; }
        //Mapping

        //WebUserAccount
        public int? WebUserAccountId { get; set; }
        public virtual WebUserAccount? WebUserAccount { get; set; }

        //Employee
        public int? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }//Tip
        //OrderDetail
        public virtual ICollection<ActivityTicketOrderDetail>? ActivityTicketOrderDetails { get; set; }

    }
}
