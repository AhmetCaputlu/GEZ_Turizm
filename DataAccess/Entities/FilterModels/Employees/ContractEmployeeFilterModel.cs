using DataAccess.Entities.Enums;

namespace DataAccess.Entities.FilterModels.Employees
{
    public class ContractEmployeeFilterModel : BaseEmployeeFilterModel
    {
        public DriverLicense? DriverLicense { get; set; } = null;
        public Language? Language { get; set; } = null;
    }
}
