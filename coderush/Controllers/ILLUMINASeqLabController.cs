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
    
    public class ILLUMINASeqLabController : Controller
    {
        [Authorize(Roles = Pages.MainMenu.ILLUMINASeqLab_NovaSeq6000.RoleName)]
        public IActionResult NovaSeq6000()
        {
            return View();
        }

        [Authorize(Roles = Pages.MainMenu.ILLUMINASeqLab_Others.RoleName)]
        public IActionResult Others()
        {
            return View();
        }
    }
}