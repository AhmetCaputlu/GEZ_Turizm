using BusinessLogic.Enums;

namespace BusinessLogic.DTOs.OperationResult
{
    /// <summary>
    /// Bu sınıf BLL katmanında dönmesi gereken sonuç durumunu ve açıklamasının(varsa) nesne olarak dönmesini sağlar.
    /// </summary>
    public class NotificationType
    {
        public Notifications ResultType { get; set; }
        public string? Description { get; set; }
    }
}
