using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementSystem.Controllers
{
    public class CategoryController : ApiBaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Helllo world");
        }
    }
}
