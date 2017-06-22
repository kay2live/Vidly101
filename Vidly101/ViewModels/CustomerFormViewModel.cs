using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly101.Models;

namespace Vidly101.ViewModels
{
    public class CustomerFormViewModel
    {
        //We don't use any addtional functionalities 
        //public List<MembershipType> MembershipTypes { get; set; } 

        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}