namespace DataAccess.Entities.FilterModels.Vehicles
{
    public class VehicleFilterModel : BaseVehicleFilterModel
    {
        public DateTime? PurchaseDate { get; set; } = null;
        public bool? DescendingByMarketValue { get; set; } = null;
    }
}
