namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseCompanyResponseDTO : BaseResponseModelDTO
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
