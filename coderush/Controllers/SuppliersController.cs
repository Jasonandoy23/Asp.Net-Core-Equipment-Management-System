using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    [Authorize(Roles = Pages.MainMenu.Suppliers.RoleName)]
    public class SuppliersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}