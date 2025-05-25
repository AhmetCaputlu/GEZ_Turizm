using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DTOs.Companies.PartnerCompanies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace BusinessLogic.Mapping
{
    internal class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            CreateMap<PartnerCompanyTransaction, TransactionResponseDTO>()
                .ForMember(x => x.PartnerCompanyResponseDTO, y => y.MapFrom(z => z.PartnerCompany));
            CreateMap<TransactionRequestDTO, PartnerCompanyTransaction>();
        }
    }
}
