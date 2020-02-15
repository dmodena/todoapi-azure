using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    [Table("todo")]
    public class Todo
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("title")]
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(255, ErrorMessage = "Maximum length for title is 255")]
        public string Title { get; set; }

        [Column("completed")]
        [Required(ErrorMessage = "Completed information is required")]
        public bool Completed { get; set; }

        [Column("created_at")]
        [Required(ErrorMessage = "Creation date is required")]
        public DateTime CreatedAt { get; set; }
    }
}
