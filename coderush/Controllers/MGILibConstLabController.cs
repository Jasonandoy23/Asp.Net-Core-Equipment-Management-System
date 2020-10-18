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
    
    public class MGILibConstLabController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_TapeStation4200.RoleName)]
        public IActionResult TapeStation4200()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_Centrifuge5810R.RoleName)]
        public IActionResult Centrifuge5810R()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_Fridge.RoleName)]
        public IActionResult Fridge()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_HaierHYC6102c8c.RoleName)]
        public IActionResult HaierHYC6102c8c()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_MGISP100.RoleName)]
        public IActionResult MGISP100()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_MGISP960.RoleName)]
        public IActionResult MGISP960()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_Others.RoleName)]
        public IActionResult Others()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_PureWaterSystem.RoleName)]
        public IActionResult PureWaterSystem()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_ThermalCycler.RoleName)]
        public IActionResult ThermalCycler()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.MGILibConstLab_Vortexer.RoleName)]
        public IActionResult Vortexer()
        {
            return View();
        }
    }
}