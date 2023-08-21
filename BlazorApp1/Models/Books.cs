using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Books
    {
        [Key]
        public int book_id { get; set; }
        
        public int user_id { get; set; }

        public string book_title { get; set; }

        public string book_genre { get; set; }

        public string author { get; set; }

        public int page_count { get; set; }

        public int hasbeenread { get; set; }
        public string book_image { get; set;}
        public int page_number { get; set; }

    }
}
