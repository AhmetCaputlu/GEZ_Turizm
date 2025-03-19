using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseCompanyModel : BaseModel
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
