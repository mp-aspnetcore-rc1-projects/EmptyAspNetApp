using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicAspApp.Models
{
    public class Snippet : object
    {
        public int Id { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime UpateDate { get; set; }

        [StringLength(5000, MinimumLength = 3)]
        [Required]
        public string Content { get; set; }

        [Required]
        public int ComputerLanguageId { get; set; }

        [ForeignKey("ComputerLanguageId")]
        public ComputerLanguage ComputerLanguage { get; set; }
    }
}
