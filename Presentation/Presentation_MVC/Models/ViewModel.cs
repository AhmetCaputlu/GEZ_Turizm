using BusinessLogic.DTOs.Abstracts;

namespace Presentation_MVC.Models
{
    public class ViewModel<TRequest> where TRequest : BaseRequestModelDTO, new()
    {
        TRequest Model { get; set; } = new();
    }
}
