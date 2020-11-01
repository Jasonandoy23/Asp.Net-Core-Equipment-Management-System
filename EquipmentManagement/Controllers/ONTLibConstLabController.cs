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
    
    public class ONTLibConstLabController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.ONTLibConstLab_MicroLabNGSSTAR.RoleName)]
        public IActionResult MicroLabNGSSTAR()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ONTLibConstLab_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }
    }
}