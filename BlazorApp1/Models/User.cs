using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        public string email_address { get; set; }

        [Required]
        public string hash_password { get; set; }
    }
}
