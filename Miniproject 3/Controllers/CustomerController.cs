using Microsoft.AspNetCore.Mvc;

namespace Miniproject_3.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
