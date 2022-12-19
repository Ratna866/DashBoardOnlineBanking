using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DashBoardOnlineBanking.Models
{
    public class ChangePassword
    {
        [Display(Name="Old Password")]
        [Required(ErrorMessage ="Old Password is required")]
        [DataType(DataType.Password)]
        public string  OldPassword { get; set; }

        [Display(Name = "New Password")]
        [Required(ErrorMessage = "New Password is required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name = "Confirm New Password")]
        [Required(ErrorMessage = "Confirm New Password is required")]
        [Compare(otherProperty:"NewPassword",ErrorMessage ="New password doesn't match")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
    }
}

