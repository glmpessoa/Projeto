using Microsoft.AspNetCore.Mvc;

namespace InfoStore.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
