using AutoMapper;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.WebUser;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Mapping.WebUsers
{
    public class WebUserProfileMappingProfile : Profile
    {
        public WebUserProfileMappingProfile()
        {
            CreateMap<WebUserProfileRequestDTO, WebUserProfile>();
            CreateMap<WebUserProfile, WebUserProfileResponseDTO>();
            
        }
    }
}
