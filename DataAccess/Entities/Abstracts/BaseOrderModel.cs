using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseOrderModel : BaseModel
    {
        public string? Note { get; set; }
        public string WebUserEmail { get; set; }
        //Mapping

        //WebUserAccount
        public int? WebUserAccountId { get; set; }
        public virtual WebUserAccount? WebUserAccount { get; set; }

        //Employee
        public int? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
