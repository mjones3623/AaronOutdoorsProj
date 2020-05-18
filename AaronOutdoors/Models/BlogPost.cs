using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AaronOutdoors.Models
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        
        public List<BlogComment> BlogCommentList { get; set; }
    }
}
