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
    
    public class CP1Controller : Controller
    {
        [Authorize(Roles = Pages.MainMenu.CP1_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.CP1_ThermoFisher80.RoleName)]
        public IActionResult ThermoFisher80()
        {
            return View();
        }


    }
}