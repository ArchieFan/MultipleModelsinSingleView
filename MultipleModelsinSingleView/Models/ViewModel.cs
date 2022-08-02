using MultipleModelsinSingleView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModelsinSingleView.Models
{
    public class ViewModel
    {
        public IEnumerable<Scheme> Schemes { get; set; }
        public IEnumerable<Member> Members { get; set; }
    }
}