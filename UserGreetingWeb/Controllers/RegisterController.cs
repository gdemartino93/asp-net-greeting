using Microsoft.AspNetCore.Mvc;
using UserGreetingWeb.Models;

namespace UserGreetingWeb.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Salva(User user)
        {
            //return RedirectToAction()
        }
    }
}
