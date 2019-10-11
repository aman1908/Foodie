using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Foodie.Models;
using System.ComponentModel.DataAnnotations;

namespace Foodie.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Please provide name", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide contact number", AllowEmptyStrings = false)]
        public int ContactNumber { get; set; }
    }
}