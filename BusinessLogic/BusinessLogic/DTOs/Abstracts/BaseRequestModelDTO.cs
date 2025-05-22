using System.ComponentModel.DataAnnotations;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseRequestModelDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public DataStatus Status { get; set; }
    }
}
