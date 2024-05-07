using Microsoft.AspNetCore.Mvc;

namespace WebAppSort.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
