using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coderush.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    
    public class Lab1Controller : Controller
    {
        [Authorize(Roles = Pages.MainMenu.Lab1_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.Lab1_Others.RoleName)]
        public IActionResult Others()
        {
            return View();
        }
    }
}