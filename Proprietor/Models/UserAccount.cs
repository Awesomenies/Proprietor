using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proprietor.Models
{
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "First name is requrid.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is requrid.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is requrid.")]
        //TODO: VALIDATE EMAIL HERE
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Username is requrid.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is requrid.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public virtual GameAccount GameAccount { get; set; }

    }
}