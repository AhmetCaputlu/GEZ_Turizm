using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.PassTickets
{
    public class PassTicketFilterModel : BaseFilterModel
    {
        public decimal? MinPrice { get; set; } = null;
        public decimal? MaxPrice { get; set; } = null;
        public bool? DescendingByTotalCost { get; set; } = null;
        public bool? DescendingByCommissionRate { get; set; } = null;

    }
}
