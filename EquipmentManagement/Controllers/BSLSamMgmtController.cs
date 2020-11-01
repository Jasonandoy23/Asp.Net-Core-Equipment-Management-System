using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EquipmentManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentManagement.Controllers
{
    
    public class BSLSamMgmtController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_BioSafetyCabinet.RoleName)]
        public IActionResult BioSafetyCabinet()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_BradyPrinteri5100.RoleName)]
        public IActionResult BradyPrinteri5100()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_CenceCentrifugeCL5R.RoleName)]
        public IActionResult CenceCentrifugeCL5R()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_Centrifuge.RoleName)]
        public IActionResult Centrifuge()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_Centrifuge5702.RoleName)]
        public IActionResult Centrifuge5702()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_ESCOClassIITypeA2.RoleName)]
        public IActionResult ESCOClassIITypeA2()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_LPVortexMixer.RoleName)]
        public IActionResult LPVortexMixer()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_MicroLabSTARlet.RoleName)]
        public IActionResult MicroLabSTARlet()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_MultitubeVortexer.RoleName)]
        public IActionResult MultitubeVortexer()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_Refrigerator.RoleName)]
        public IActionResult Refrigerator()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_STPlusSeriesCentrifuge.RoleName)]
        public IActionResult STPlusSeriesCentrifuge()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.BSLSamMgmt_TheromoMixer.RoleName)]
        public IActionResult TheromoMixer()
        {
            return View();
        }

    }
}