using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Test
    {
        [Key]
        public int name { get; set; }

        public string favourite_colour { get; set; }
    }
}
