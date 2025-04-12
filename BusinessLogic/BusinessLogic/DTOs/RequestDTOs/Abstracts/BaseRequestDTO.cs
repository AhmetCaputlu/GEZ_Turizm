using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.RequestDTOs.Abstracts
{
    public abstract class BaseRequestDTO
    {
        public int Id { get; set; }
        public DataStatus Status { get; set; }
    }
}
