using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Employees;
using BusinessLogic.DTOs.Vehicles;

namespace BusinessLogic.DTOs.Companies.Suppliers
{
    public class RentalVehicleSupplierResponseDTO:BaseResponseModelDTO
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public List<RentalVehicleResponseDTO>? RentalVehicleResponseDTOs { get; set; }
    }
}
