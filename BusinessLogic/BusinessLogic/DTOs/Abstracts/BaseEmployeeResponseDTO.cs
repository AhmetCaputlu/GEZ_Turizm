namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseEmployeeResponseDTO : BaseResponseModelDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte? Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;

                if (BirthDate.Date > today.AddYears(-age))
                {
                    age--;
                }

                return (byte?)age;
            }
        }
        public string? Email { get; set; }
        public string? TCN_Passport { get; set; }
        public DateTime HireDate { get; set; }
        public int Experience { get; set; }
    }
}
