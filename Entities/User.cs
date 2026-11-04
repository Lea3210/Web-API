using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string password { get; set; }

        [EmailAddress]
        public string email { get; set; }

        public int id { get; set; }

    }
}
