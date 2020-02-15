using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Todo
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Completed information is required")]
        public bool Completed { get; set; }

        [Required(ErrorMessage = "Creation date is required")]
        public DateTime CreatedAt { get; set; }
    }
}
