using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AaronOutdoors.Models
{
    public class BlogView
    {
        public int BlogViewId { get; set; }
        public BlogPost BlogViewPost { get; set; }
        public BlogComment BlogViewComment { get; set; }
    }
}
