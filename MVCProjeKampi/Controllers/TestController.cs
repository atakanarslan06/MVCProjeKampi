using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
