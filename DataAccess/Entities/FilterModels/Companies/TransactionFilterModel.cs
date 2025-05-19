using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;
using Microsoft.EntityFrameworkCore.Query;

namespace DataAccess.Entities.FilterModels.Companies
{
    public class TransactionFilterModel : BaseFilterModel
    {
        public int? PartnerCompanyId { get; set; } = null;
        public TransactionType? TransactionType { get; set; } = null;
        public decimal? FirstTotalCost { get; set; } = null;
        public decimal? LastTotalCost { get; set; } = null;
        public bool? DescendingByTotalCost { get; set; } = null;
    }
}
