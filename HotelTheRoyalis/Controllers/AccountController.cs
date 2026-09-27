using Microsoft.AspNetCore.Mvc;

namespace HotelTheRoyalis.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Recuperar()
        {
            return View();
        }
    }
}