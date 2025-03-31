namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseOrderDetailModel : BaseModel
    {
        public decimal UnitPrice { get; set; }//Bu biletler ve ürünlerden NetCost Property'sini alacak
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }//Vip'den bağımsız tanımlanan indirim.
        public decimal? TotalCost { get { return (UnitPrice * Quantity) * (decimal?)(1 - Discount); } set { } }
    }
}
