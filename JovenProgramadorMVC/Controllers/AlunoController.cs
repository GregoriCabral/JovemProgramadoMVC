using Microsoft.AspNetCore.Mvc;

namespace JovenProgramadorMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
