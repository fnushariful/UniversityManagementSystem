using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementSystem.Controllers
{
    public class ProductController : ApiBaseController
    {
        [HttpGet]
        public IActionResult Index() {
            return Ok("Hello World");
        }
    }
}
