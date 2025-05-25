using BusinessLogic.DTOs.Activities;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Activities;

namespace BusinessLogic.Services.Abstracts.Activities
{
    public interface IActivityService :  IGenericService<DataAccess.Entities.Models.Activities.Activity, ActivityResponseDTO, ActivityRequestDTO, ActivityFilterModel>
    {
   
    }
}
