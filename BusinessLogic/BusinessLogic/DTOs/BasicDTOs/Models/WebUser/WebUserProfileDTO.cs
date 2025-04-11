using BusinessLogic.DTOs.BasicDTOs.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.DTOs.BasicDTOs.Models.WebUser
{
    public class WebUserProfileDTO:BaseModelDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
