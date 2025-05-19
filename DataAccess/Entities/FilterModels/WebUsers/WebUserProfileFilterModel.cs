using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.WebUsers
{
    public class WebUserProfileFilterModel : BaseFilterModel
    {
        public string? Name { get; set; } = null;
        public Gender? Gender { get; set; } = null;
        public bool? DescendingAge { get; set; } = null;
    }
}
