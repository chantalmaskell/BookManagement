using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [MaxLength(100)]
        public string first_name { get; set; }

        [MaxLength(100)]
        public string last_name { get; set; }

        [MaxLength(100)]
        public string email_address { get; set; }

        public string hash_password { get; set; }
    }
}
