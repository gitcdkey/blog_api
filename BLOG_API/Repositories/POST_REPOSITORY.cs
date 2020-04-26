using BLOG_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOG_API.Repositories
{
    public class POST_REPOSITORY : BASE_REPOSITORY
    {
        public IEnumerable<Post> FindAll()
        {
            return Query<Post>("select * from posts");
        }

        public int Create(PostCreate e)
        {
            return Execute("insert into posts(id,title,preview,content,author,publish_date) values(:id,:title,:preview,:content,:author,:publish_date)", e);
        }
    }
}
