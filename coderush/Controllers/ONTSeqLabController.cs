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
    
    public class ONTSeqLabController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_Centrifuge5810R.RoleName)]
        public IActionResult Centrifuge5810R()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_Centrifuge5424.RoleName)]
        public IActionResult Centrifuge5424()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_PharmRef1.RoleName)]
        public IActionResult PharmRef1()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_PharmRef2.RoleName)]
        public IActionResult PharmRef2()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_ThermofisherSciFridge.RoleName)]
        public IActionResult ThermofisherSciFridge()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_HPLaserMFP137fnw.RoleName)]
        public IActionResult HPLaserMFP137fnw()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_PromethIONDataAcqTower.RoleName)]
        public IActionResult PromethIONDataAcqTower()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_PromethIONSeqUnit.RoleName)]
        public IActionResult PromethIONSeqUnit()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_IndDehumidifierClimatePlus.RoleName)]
        public IActionResult IndDehumidifierClimatePlus()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTSeqLab_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }
    }
}