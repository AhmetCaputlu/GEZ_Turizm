using DataAccess.Entities.Enums;

namespace DataAccess.Entities.Interfaces
{
    public interface IEntity
    {
        string Guid { get; set; }
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedID { get; set; }
        string CreatedIPAddress { get; set; }
        DateTime? UpdatedDate { get; set; }
        string? UpdatedID { get; set; }
        string? UpdatedIPAddress { get; set; }
        DataStatus Status { get; set; }

    }
}
