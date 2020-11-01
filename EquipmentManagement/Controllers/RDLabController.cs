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
    
    public class RDLabController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.RDLab_BioSafetyCabinet.RoleName)]
        public IActionResult BioSafetyCabinet()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_Centrifuge5424R.RoleName)]
        public IActionResult Centrifuge5424R()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_CompactDrybathS.RoleName)]
        public IActionResult CompactDrybathS()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.RDLab_ESCOClassIITypeA2BioSafetyCabinet.RoleName)]
        public IActionResult ESCOClassIITypeA2BioSafetyCabinet()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_FastPrep966010500.RoleName)]
        public IActionResult FastPrep966010500()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_GelDocE7Imager.RoleName)]
        public IActionResult GelDocE7Imager()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_HaierDW40L508DeepFreezer40c20c.RoleName)]
        public IActionResult HaierDW40L508DeepFreezer40c20c()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.RDLab_HaierHYC6102c8c.RoleName)]
        public IActionResult HaierHYC6102c8c()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_HeatStri.RoleName)]
        public IActionResult HeatStri()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_HulaMixer.RoleName)]
        public IActionResult HulaMixer()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.RDLab_LPVortexMixer.RoleName)]
        public IActionResult LPVortexMixer()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_MasterCycler.RoleName)]
        public IActionResult MasterCycler()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_MettlerToledoNEWClassicMF.RoleName)]
        public IActionResult MettlerToledoNEWClassicMF()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_MicrowaveOven.RoleName)]
        public IActionResult MicrowaveOven()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_MiniSpin.RoleName)]
        public IActionResult MiniSpin()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_NanodropOne.RoleName)]
        public IActionResult NanodropOne()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_PowerPacBasic.RoleName)]
        public IActionResult PowerPacBasic()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_PrecisionGP10WaterBath.RoleName)]
        public IActionResult PrecisionGP10WaterBath()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_Qubit4Fluorometer.RoleName)]
        public IActionResult Qubit4Fluorometer()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_SWP01.RoleName)]
        public IActionResult SWP01()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_ThermalCycler.RoleName)]
        public IActionResult ThermalCycler()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_ThermoScientificMyspin6.RoleName)]
        public IActionResult ThermoScientificMyspin6()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RDLab_ThermoScientificMyspin12.RoleName)]
        public IActionResult ThermoScientificMyspin12()
        {
            return View();
        }
    }
}