using AutoMapper;
using BusinessLogic.DTOs.WebUser;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Mapping
{
    public class WebUserAccountMappingProfile : Profile
    {
        public WebUserAccountMappingProfile()
        {
            CreateMap<WebUserAccount,WebUserAccountResponseDTO>();
            CreateMap<WebUserAccountRequestDTO,WebUserAccount>();
        }
    }
}
