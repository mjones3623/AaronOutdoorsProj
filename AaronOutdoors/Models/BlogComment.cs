using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AaronOutdoors.Models
{
    public class BlogComment
    {
        public int BlogCommentId { get; set; }
        public int BlogCommentSiteUserId { get; set; }
        public string BlogCommentText { get; set; }
        public DateTime BlogCommentDateTime { get; set; }
    }
}
