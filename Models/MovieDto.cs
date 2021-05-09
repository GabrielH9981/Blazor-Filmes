using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowdeBola.Models
{
    public class MovieDto
    {
        public int Id {get; set;}

        [Required]
        public string Title {get; set;}
        public DateTime ReleaseDate {get; set;}
        public string Genre {get; set;}
        public decimal Price {get; set;}
        public string Rating {get; set;}
        public ICollection<Actor> Actors { get; set; }
    }
}