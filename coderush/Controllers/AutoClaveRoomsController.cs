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
    
    public class AutoClaveRoomsController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.ACR_PumpOnGround.RoleName)]
        public IActionResult PumpOnGround()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ACR_ShihlinCtrl.RoleName)]
        public IActionResult ShihlinCtrl()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ACR_SteamSterilizerMSTV.RoleName)]
        public IActionResult SteamSterilizerMSTV()
        {
            return View();
        }
    }
}