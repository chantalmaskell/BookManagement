using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class RemoveBook
    {
        [Key]
        public int book_id { get; set; }
    }
}