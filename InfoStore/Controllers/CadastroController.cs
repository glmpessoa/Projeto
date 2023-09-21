using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InfoStore.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Produto()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }


    }
}