using Microsoft.AspNetCore.Mvc;

namespace CardGame.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
