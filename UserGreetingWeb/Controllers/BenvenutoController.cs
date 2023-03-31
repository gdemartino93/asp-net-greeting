using Microsoft.AspNetCore.Mvc;

namespace UserGreetingWeb.Controllers
{
    public class BenvenutoController : Controller
    {
        public IActionResult Benvenuto(string nome)
        {
            ViewBag.Nome = nome;
            return View();
        }
    }
}
