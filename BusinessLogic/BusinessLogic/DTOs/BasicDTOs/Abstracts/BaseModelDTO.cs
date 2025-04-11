using System.ComponentModel.DataAnnotations;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.BasicDTOs.Abstracts
{
    public abstract class BaseModelDTO
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
