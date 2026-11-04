using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class LoginUser
    {
        [Required]
        public string lpassword { get; set; }
        [Required]
        public string lemail { get; set; }
    }
}

