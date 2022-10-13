using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Profile
    {

        [Required, MinLength(2, ErrorMessage ="Please enter a valid name.")]
        public string DisplayName { get; set; } = null!;
        [Required, EmailAddress(ErrorMessage ="Please enter a valid email address.")]
        public string Email { get; set; } = null!;
        
        public Profile( string displayname, string email)
        {
            
            DisplayName = displayname;
            Email = email;
        }

    }
}
