using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [MaxLength(100)]
        public string first_name { get; set; }

        [Required]
        [MaxLength(100)]
        public string last_name { get; set; }

        [Required]
        [MaxLength(100)]
        public string email_address { get; set; }
    }
}
