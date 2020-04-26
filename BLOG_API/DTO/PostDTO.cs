using BLOG_API.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BLOG_API.DTO
{
    public class PostDTO
    {
        public Guid id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string preview { get; set; }
        [Required]
        public string content { get; set; }
        public string author { get; set; }
        public DateTime publishDate { get; set; }

        public PostDTO(Post e)
        {
            id = Guid.Parse(e.id);
            title = e.title;
            preview = e.preview;
            content = e.content;
            publishDate = Convert.ToDateTime(e.publish_date);
        }

        public PostDTO()
        {

        }

    }
}
