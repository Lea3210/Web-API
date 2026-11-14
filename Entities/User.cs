using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        [Required]
        //Public properties are PascalCase in C# (Name). Keep the names as they are in the data file; use PropertyNameCaseInsensitive = true in the JsonSerializerOptions to read them.
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
