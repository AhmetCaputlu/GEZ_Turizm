using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Orders
{
    public class OrderFilterModel : BaseFilterModel
    {
        public string? Note { get; set; } = null;
        public string? Email { get; set; } = null;
    }
}
