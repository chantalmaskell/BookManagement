using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Books
    {
        [Key]
        public int book_id { get; set; }

        public int user_id { get; set; }

        [Required]
        public string book_title { get; set; }

        [Required]
        public string book_genre { get; set; }

        [Required]
        public string author { get; set; }

        [Required]
        public int page_count { get; set; }

        [Required]
        public int hasbeenread { get; set; }

        public int page_number { get; set; }

        public string book_image { get; set; }

        public int rating { get; set; }

        public string review { get; set; }

        public string book_description { get; set; }
    }
}
