using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 30 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter what you did today!")]
        public string Content { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a date!")]
        public DateTime Created { get; set; } = DateTime.Now;

        // Add a read-only property named Slug
        // public string Slug => Title?.Replace(' ', '-').ToLower() + '-' + Created.ToString();
        public string Slug => (Title?.Length > 7 ? Title.Substring(0, 7) : Title)?.Replace(' ', '-').ToLower()
                      + "-" + Created.ToString("yyyyMMdd");



    }
}
