namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseOrderDetailModel : BaseModel
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal? TotalCost { get { return (UnitPrice * Quantity) * (1 - Discount); } set { } }
    }
}
