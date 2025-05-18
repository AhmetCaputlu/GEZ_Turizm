using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Companies
{
    public class BaseCompanyFilterModel : BaseFilterModel
    {
        public string? CompanyName { get; set; } = null;
        public string? ContactName { get; set; } = null;
        public string? ContactTitle { get; set; } = null;
        public string? Email { get; set; } = null;
        public string? PhoneNumber { get; set; } = null;
        public string? Address { get; set; } = null;
    }
}
