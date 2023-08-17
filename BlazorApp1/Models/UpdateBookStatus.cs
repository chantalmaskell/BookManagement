using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class UpdateBookStatus
    {
        [Key]
        public int book_id { get; set; }

        [Required]
        public int hasbeenread { get; set; }
    }
}