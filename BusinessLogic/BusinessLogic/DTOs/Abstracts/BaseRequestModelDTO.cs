using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseRequestModelDTO
    {
        public int Id { get; set; }
        public DataStatus Status { get; set; }
    }
}
