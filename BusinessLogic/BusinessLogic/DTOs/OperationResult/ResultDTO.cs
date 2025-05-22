using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.DTOs.OperationResult
{
    /// <summary>
    /// Bu sınıf Response döndürmesi gereken metotlarda, kriterleri ve hata mesajlarını da taşıyabilmesi için tasarlandı.
    /// </summary>
    public class ResultDTO<TResponse, TFilter> where TResponse : BaseResponseModelDTO where TFilter : BaseFilterModel
    {
        public TFilter? DynamicFilter { get; set; }
        public IEnumerable<TResponse>? List { get; set; }
        public NotificationType? NotificationType { get; set; }
    }
}
