using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly101.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly101.ViewModels
{
    public class MovieFormViewModel
    {
        //We don't use any addtional functionalities 
        //public List<Genre> MembershipTypes { get; set; } 

        public IEnumerable<Genre> Genre { get; set; }
        //public Movie Movie { get; set; }

        public int? Id { get; set; }    //nullable

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }  //nullable

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }  //nullable

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        [Required(ErrorMessage = "The field Number in Stock must be between 1 and 20")]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
                

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;

        }
    }
}