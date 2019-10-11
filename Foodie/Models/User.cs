using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Foodie.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please provide password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be 6 char long")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "confirm password does not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please provide full name", AllowEmptyStrings = false)]
        public string FullName { get; set; }
    }
}