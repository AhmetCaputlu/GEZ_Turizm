using AutoMapper;
using BusinessLogic.DTOs.BasicDTOs.Models.WebUser;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Mappings.WebUser
{
    public class WebUserAccountMap : Profile
    {
        public WebUserAccountMap()
        {
            CreateMap<WebUserAccount,WebUserAccountDTO>().ReverseMap();
            CreateMap<WebUserAccount,WebUserAccountDTO>().ForMember(x=>x.WebUserProfile,x=>x.MapFrom(x=>x.WebUserProfile));
        }
    }
}
