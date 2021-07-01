using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryApp.Models
{
    public class Books
    {
        public int Id { get; set; }

        [Display(Name = "Book ID")]
        [Required]
        public int BookId { get; set; }

        [Display(Name = "Title")]
        [Required]
        public String BookTitle { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public string BookGenre { get; set; }

        [Display(Name = "Publisher")]
        [Required]
        public string BookPublisher { get; set; }

        [Display(Name = "Author")]
        [Required]
        public string BookAuthor { get; set; }

        [Display(Name = "Year of Publishing")]
        [Required]
        public int BookYear { get; set; }
    }
}
