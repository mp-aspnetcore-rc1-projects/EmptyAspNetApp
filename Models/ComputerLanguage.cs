using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicAspApp.Models
{

    public class ComputerLanguage
    {
        public int Id { get; set; }
        [StringLength(200, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [InverseProperty("ComputerLanguage")]
        public virtual List<Snippet> Snippets { get; set; }
    }
}