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
    
    public class ILLUMINALibConstController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.ILLUMINALibConst_Others.RoleName)]
        public IActionResult Others()
        {
            return View();
        }
    }
}