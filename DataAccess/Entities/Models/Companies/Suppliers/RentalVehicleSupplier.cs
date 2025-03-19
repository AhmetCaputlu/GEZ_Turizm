using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Models.Companies.Suppliers
{
    public class RentalVehicleSupplier:BaseCompanyModel
    {
        //Mapping
        public virtual ICollection<RentalVehicle>? RentalVehicles { get; set; }
    }
}
