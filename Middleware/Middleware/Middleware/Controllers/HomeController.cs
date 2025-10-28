using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        // GET api/home
        [HttpGet]
        public string Hello()
        {
            return "? Hello from Controller!";
        }
    }
}
