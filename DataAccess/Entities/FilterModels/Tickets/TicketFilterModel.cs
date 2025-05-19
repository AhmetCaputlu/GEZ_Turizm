using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Tickets
{
    public class TicketFilterModel : BaseFilterModel
    {
        public string? TicketName { get; set; } = null;
        public string? SeatNumber { get; set; } = null;
        public DateTime? DepartureDate { get; set; } = null;
        public DateTime? ArrivalDate { get; set; } = null;
        public decimal? MinCost { get; set; } = null;
        public decimal? MaxCost { get; set; } = null;
        public PaymentStatus? PaymentStatus { get; set; } = null;
        public Currency? Currency { get; set; } = null;
        public bool? DescendingByTotalCost { get; set; } = null;
    }
}
