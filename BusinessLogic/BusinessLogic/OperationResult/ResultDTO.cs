using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.OperationResult
{
    /// <summary>
    /// Bu sınıf Response döndürmesi gereken metotlarda, kriterleri ve hata mesajlarını da taşıyabilmesi için tasarlandı.
    /// </summary>
    public class ResultDTO<TResponse, TFilter> where TResponse : BaseResponseModelDTO where TFilter : BaseFilterModel
    {
        public TFilter? DynamicFilter { get; set; }
        public List<TResponse>? List { get; set; } = new();
        public int? FilterId { get; set; }
        public TResponse? SelectedEntity { get; set; }
        public NotificationDTO? NotificationType { get; set; }
    }
}
