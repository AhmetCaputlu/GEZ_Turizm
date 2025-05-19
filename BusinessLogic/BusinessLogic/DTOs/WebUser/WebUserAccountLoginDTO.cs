using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.WebUser
{
    public class WebUserAccountLoginDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Password { get; set; }
    }
}
