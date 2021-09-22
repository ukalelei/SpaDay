using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must contain 5 to 15 characters")] //Username is between 5 and 15 characters.
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Passowrd must contain 6 to 20 characters")] //password is between 6 and 20 characters
        public string Password { get; set; }
        
        [EmailAddress(ErrorMessage = "Not a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        public string VerifyPassword { get; set; }
    }
}
