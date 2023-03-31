using Microsoft.AspNetCore.Mvc;

namespace UserGreetingWeb.Controllers
{
    public class BenvenutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
