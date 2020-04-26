using BLOG_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOG_API.Entities
{
    public class PostCreate : Post
    {
        public PostCreate(PostDTO e, Guid author)
        {
            this.id = Guid.NewGuid().ToString();
            this.title = e.title;
            this.preview = e.preview;
            this.content = e.content;
            this.publish_date = DateTime.Now.ToString();
            this.author = author.ToString();
        }
    }
}
