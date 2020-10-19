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
    
    public class RoboticsLabController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.RoboticsLab_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RoboticsLab_MicroLabNIMBUS.RoleName)]
        public IActionResult MicroLabNIMBUS()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.RoboticsLab_MicroLabSTAR.RoleName)]
        public IActionResult MicroLabSTAR()
        {
            return View();
        }
        [Authorize(Roles = Pages.MainMenu.RoboticsLab_Others.RoleName)]
        public IActionResult Others()
        {
            return View();
        }

    }
}