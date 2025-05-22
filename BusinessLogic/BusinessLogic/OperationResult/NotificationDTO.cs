using BusinessLogic.OperationResult.Enums;

namespace BusinessLogic.OperationResult
{
    /// <summary>
    /// Bu sınıf BLL katmanında dönmesi gereken sonuç durumunu ve açıklamasının(varsa) nesne olarak dönmesini sağlar.
    /// </summary>
    public class NotificationDTO
    {
        public NotificationType ResultType { get; set; }
        public string? Description { get; set; }
    }
}
