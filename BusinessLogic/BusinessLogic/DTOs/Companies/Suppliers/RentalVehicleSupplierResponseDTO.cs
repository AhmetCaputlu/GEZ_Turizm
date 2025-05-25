using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Employees;
using BusinessLogic.DTOs.Vehicles;

namespace BusinessLogic.DTOs.Companies.Suppliers
{
    public class RentalVehicleSupplierResponseDTO : BaseRequestModelDTO
    {
        public List<RentalVehicleResponseDTO>? RentalVehicleResponseDTOs { get; set; }
    }
}
