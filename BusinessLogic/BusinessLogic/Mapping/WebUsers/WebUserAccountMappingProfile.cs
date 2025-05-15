using AutoMapper;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.WebUser;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Mapping.WebUsers
{
    public class WebUserAccountMappingProfile : Profile
    {
        public WebUserAccountMappingProfile()
        {
            CreateMap<WebUserAccountRequestDTO, WebUserAccount>();
            CreateMap<WebUserAccount, WebUserAccountResponseDTO>()
                .ForMember(x => x.WebUserProfileResponseDTO, y => y.MapFrom(z => z.WebUserProfile));

        }
    }
}
