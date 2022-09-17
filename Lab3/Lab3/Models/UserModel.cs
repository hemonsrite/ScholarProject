using Lab3.Attribute;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Username should be atleast of 3 characters.")]
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter valid email.")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$@!%&*?]).*"
            ,ErrorMessage = "Password should consist atlease 1 uppercase character, 1 lowercase character, 1 special character and a number.")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password should be atleast 8 characters.")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Mobile")]
        public string Contact { get; set; }

        [Required]
        public string Gender { get; set; }

        [Display(Name = "Accept Terms")]
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool IsTerms { get; set; }
    }
}
