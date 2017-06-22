using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly101.Models;

namespace Vidly101.ViewModels
{
    public class MovieFormViewModel
    {
        //We don't use any addtional functionalities 
        //public List<Genre> MembershipTypes { get; set; } 

        public IEnumerable<Genre> Genre { get; set; }
        public Movie Movie { get; set; }
    }
}