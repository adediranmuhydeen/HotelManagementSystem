using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Core.DTOs
{
    public class UpdatePasswordDTO
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string Token { get; set; }
    }
}
