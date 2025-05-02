using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseResponseModelDTO
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
