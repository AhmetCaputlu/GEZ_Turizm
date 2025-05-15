using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.Tickets
{
    public class ActivityTicketRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Karakter uzunluğu 2-50 karakter olabilir!")]
        public string TicketHolderName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Karakter uzunluğu max 4 karakter olabilir!(C102 ,B84 vb.)")]
        public string SeatNumber { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Karakter uzunluğu 5-150 karakter olabilir!")]
        public string DepartureAdress { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Karakter uzunluğu 5-150 karakter olabilir!")]
        public string DestinationAdress { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime DepartureDate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime ArrivalDate { get; set; }
        [Range(10,9999,ErrorMessage= "Bilet Fiyat Aralığı 10-9999 arasında olmalıdır!!")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public int? ActivityId { get; set; }//Nav Property
    }
}
