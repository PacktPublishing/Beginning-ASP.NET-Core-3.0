using Microsoft.AspNetCore.Mvc;

namespace hello_world.Controllers
{
    public class BlogController : Controller
    {
        [Route("Blog/{id:int}")]
        [Route("MySuperBlog/{id:int}")]
        public IActionResult Story(int id)
        {
            return Content(id.ToString());
        }
    }
}