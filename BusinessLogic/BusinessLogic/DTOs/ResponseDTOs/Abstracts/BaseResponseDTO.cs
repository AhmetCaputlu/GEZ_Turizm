using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.ResponseDTOs.Abstracts
{
    public abstract class BaseResponseDTO
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
