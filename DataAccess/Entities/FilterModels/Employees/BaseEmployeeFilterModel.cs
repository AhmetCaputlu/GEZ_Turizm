using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Employees
{
    public class BaseEmployeeFilterModel:BaseFilterModel
    {
        public string? Name { get; set; } = null;
        public Gender? Gender { get; set; } = null;
        public DateTime? BirthDate { get; set; } = null;
        public int? Age { get; set; } = null;
        public DateTime? HireDate { get; set; } = null;
        public int? Experience { get; set; } = null;
    }
}
