using DataAccess.Configurations.Abstracts;

namespace DataAccess.Entities.FilterModels.Vehicles
{
    public class RentalVehicleFilterModel : BaseVehicleFilterModel
    {
        public bool? DescendingByRentalDay { get; set; } = null;
        public bool? DescendingFee { get; set; } = null;
    }
}
