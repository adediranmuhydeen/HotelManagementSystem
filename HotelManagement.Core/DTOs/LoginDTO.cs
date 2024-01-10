using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Core.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "AppUser Name is required")]
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
