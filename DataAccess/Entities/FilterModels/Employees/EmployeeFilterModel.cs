using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Employees
{
    public class EmployeeFilterModel : BaseEmployeeFilterModel
    {
        public Department? CurrentPosition { get; set; } = null;
    }
}
