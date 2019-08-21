using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime ReleaseDate { get; set; }
        
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}