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
    
    public class BSLDNAExtController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_Centrifuge.RoleName)]
        public IActionResult Centrifuge()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_Centrifuge5424.RoleName)]
        public IActionResult Centrifuge5424()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_FLUOstarOmega.RoleName)]
        public IActionResult FLUOstarOmega()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_HaierDW_40L508DeepFreezer.RoleName)]
        public IActionResult HaierDW_40L508DeepFreezer()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_HaierHYC.RoleName)]
        public IActionResult HaierHYC()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_HeatSealer.RoleName)]
        public IActionResult HeatSealer()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_KingFisherFlex.RoleName)]
        public IActionResult KingFisherFlex()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_LPVortexMixer.RoleName)]
        public IActionResult LPVortexMixer()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_MicroLabNIMBUS4.RoleName)]
        public IActionResult MicroLabNIMBUS4()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_NanoDropOne.RoleName)]
        public IActionResult NanoDropOne()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_NanoPhotometer.RoleName)]
        public IActionResult NanoPhotometer()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_PerkinElmerChemagic360.RoleName)]
        public IActionResult PerkinElmerChemagic360()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_PerkinElmerJanusG3.RoleName)]
        public IActionResult PerkinElmerJanusG3()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_QIAsymphonySP.RoleName)]
        public IActionResult QIAsymphonySP()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLDNAExt_Qubit4Fluorometer.RoleName)]
        public IActionResult Qubit4Fluorometer()
        {
            return View();
        }
    }
}