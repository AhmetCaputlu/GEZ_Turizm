using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Services.Abstracts.WebUsers;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts.WebUserR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.Concretes.WebUsers
{
    public class WebUserProfileService : GenericService<WebUserProfile, WebUserProfileResponseDTO, WebUserProfileRequestDTO, WebUserProfileFilterModel>, IWebUserProfileService
    {
        private readonly IWebUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public WebUserProfileService(IWebUserProfileRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async override Task<IEnumerable<WebUserProfileResponseDTO>> GetDynamicFilteredEntities(WebUserProfileFilterModel filterModel)
        {
            var filter = _repository.GetDynamicFilteredEntities(filterModel);
            return await filter.ProjectTo<WebUserProfileResponseDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
