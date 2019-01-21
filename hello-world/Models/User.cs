using System;
using System.ComponentModel.DataAnnotations;

namespace hello_world.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string Fullname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}