using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTest.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using WebAppTest.Models;


    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }

        public string PosterPath { get; set; }
    }
}

