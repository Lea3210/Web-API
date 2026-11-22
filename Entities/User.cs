using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        [Required]
        //In C#, properties are written in PascalCase: Name. file.txt stores the current names: if you rename them, set PropertyNameCaseInsensitive = true in the JsonSerializerOptions, so the existing file still loads
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
