using System.ComponentModel.DataAnnotations;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseModel : IEntity
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedID { get; set; }
        public string CreatedIPAddress { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedID { get; set; }
        public string? UpdatedIPAddress { get; set; }
        public DataStatus Status { get; set; }
    }
}
