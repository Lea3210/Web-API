using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class LoginUser
    {
        [Required]
        //Public properties are PascalCase in C# (LPassword). Keep the names the client sends; use PropertyNameCaseInsensitive = true in the JsonSerializerOptions to read them.
        public string lpassword { get; set; }
        [Required]
        public string lemail { get; set; }
    }
}

