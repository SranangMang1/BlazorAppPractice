namespace BlazorApp1.Data
{
    public class Profile
    {
  
        public string DisplayName { get; set; } = null!;
        public string Email { get; set; } = null!;
        
        public Profile( string displayname, string email)
        {
            
            DisplayName = displayname;
            Email = email;
        }

    }
}
