using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowdeBola.Models
{

    public class Actor
    {
        public int Id {get; set;}

        [StringLength(60, MinimumLength= 3)]
        [Required]
        public string Name_actor {get; set;}// o Nome é obrigatório e deve ter de 3 a 60 caracteres

        [Required]
        public int Movie_Id {get; set;}
    }
}