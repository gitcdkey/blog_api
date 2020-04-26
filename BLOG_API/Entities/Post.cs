using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOG_API.Entities
{
    public class Post
    {
        public string id { get; set; }
        public string title { get; set; }
        public string preview { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public string publish_date { get; set; }

    }
}
