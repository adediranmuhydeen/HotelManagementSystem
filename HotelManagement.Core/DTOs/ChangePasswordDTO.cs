﻿using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Core.DTOs
{
    public class ChangePasswordDTO
    {
        [Required(ErrorMessage = "Current Password is Required")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "New password is Required")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Comfirm Password is Required")]
        [Compare("NewPassword", ErrorMessage = "Password does not match")]
        public string ConfirmNewPassword { get; set; }
    }
}
