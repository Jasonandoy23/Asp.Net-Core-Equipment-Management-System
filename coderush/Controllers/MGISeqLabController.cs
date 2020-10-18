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
    
    public class MGISeqLabController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.MGISeqLab_Cabinet.RoleName)]
        public IActionResult Cabinet()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_Freezer.RoleName)]
        public IActionResult Freezer()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_G400.RoleName)]
        public IActionResult G400()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.MGISeqLab_PlateCentrifuge.RoleName)]
        public IActionResult PlateCentrifuge()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_PureWaterSystem.RoleName)]
        public IActionResult PureWaterSystem()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_Refrigerator.RoleName)]
        public IActionResult Refrigerator()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_T10BiochemicalPlatformPart.RoleName)]
        public IActionResult T10BiochemicalPlatformPart()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.MGISeqLab_T10Loader.RoleName)]
        public IActionResult T10Loader()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_T10OpticalPlatformPart.RoleName)]
        public IActionResult T10OpticalPlatformPart()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_T7.RoleName)]
        public IActionResult T7()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.MGISeqLab_T7Loader.RoleName)]
        public IActionResult T7Loader()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.MGISeqLab_Ztron.RoleName)]
        public IActionResult Ztron()
        {
            return View();
        }
    }
}