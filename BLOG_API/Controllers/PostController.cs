using BLOG_API.DTO;
using BLOG_API.Entities;
using BLOG_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOG_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        readonly POST_REPOSITORY _post_repo = new POST_REPOSITORY();
        [HttpGet]
        public IActionResult All()
        {
            try
            {
                return Ok(_post_repo.FindAll().Select(v => new PostDTO(v)));
            }

            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Publish([FromForm]PostDTO p)
        {
            try
            {
                _post_repo.Create(new PostCreate(p, Guid.NewGuid()));
                return Ok("Запись успешно добавлена");
            }
            catch (System.Data.SQLite.SQLiteException)
            {
                return BadRequest("Произошла ошибка записи данных. Повторите попытку позднее.");
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
