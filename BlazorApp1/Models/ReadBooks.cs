using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class ReadBooks
    {
        [Key]
        public int Book_id { get; set; }
        
        public int user_id { get; set; }

        public string book_title { get; set; }

        public string book_genre { get; set; }

        public string author { get; set; }

        public string page_count { get; set; }
    }
}
