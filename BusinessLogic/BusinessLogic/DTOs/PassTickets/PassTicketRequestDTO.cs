using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.PassTickets
{
    public class PassTicketRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(10,100000,ErrorMessage ="Fiyat aralığı 10-100.000 arasında olmak zorundadır!!")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(0,20,ErrorMessage = "Komisyon oranı 20 üzeri olamaz!")]
        public byte CommissionRate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public int? TransactionId { get; set; }//Navigation Property
    }
}
