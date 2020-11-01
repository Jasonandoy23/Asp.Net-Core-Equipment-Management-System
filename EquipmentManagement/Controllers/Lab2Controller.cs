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
    
    public class Lab2Controller : Controller
    {
        [Authorize(Roles = Pages.MainMenu.Lab2_DellDeskComp.RoleName)]
        public IActionResult DellDeskComp()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.Lab2_Others.RoleName)]
        public IActionResult Others()
        {
            return View();
        }
    }
}