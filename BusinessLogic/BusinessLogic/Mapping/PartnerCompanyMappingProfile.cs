using AutoMapper;
using BusinessLogic.DTOs.Companies.PartnerCompanies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace BusinessLogic.Mapping
{
    public class PartnerCompanyMappingProfile : Profile
    {
        public PartnerCompanyMappingProfile()
        {
            CreateMap<PartnerCompany, PartnerCompanyResponseDTO>();
            CreateMap<PartnerCompanyRequestDTO, PartnerCompany>();
        }
    }
}
