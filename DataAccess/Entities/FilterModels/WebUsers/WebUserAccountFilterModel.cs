using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.WebUsers
{
    public class WebUserAccountFilterModel : BaseFilterModel
    {
        public int? CountryId { get; set; } = null;
        public string? UserName { get; set; } = null;
        public string? Email { get; set; } = null;
    }
}
