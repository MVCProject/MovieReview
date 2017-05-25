using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    public class UserRole
    {
        [Key]
        public Guid? GetFunctionByID { get; set; }

        public string Email { get; set; }
        public string Role { get; set; }

    }
}