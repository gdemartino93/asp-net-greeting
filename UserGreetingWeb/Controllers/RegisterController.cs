using Microsoft.AspNetCore.Mvc;

namespace UserGreetingWeb.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
