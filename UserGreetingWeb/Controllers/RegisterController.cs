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

        [HttpPost]
        public ActionResult Salva(User user)
        {
            TempData["Nome"] = user.Nome;
            return RedirectToAction("Index", "Benvenuto");
        }


    }
}
