using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coderush.Data;
using coderush.Models;
using coderush.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace coderush.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/MGILibConstLab_Fridge")]
    public class MGILibConstLab_FridgeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_FridgeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_Fridge
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_Fridge()
        {
            List<MGILibConstLab_Fridge> Items = await _context.MGILibConstLab_Fridge.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_Fridge> payload)
        {
            MGILibConstLab_Fridge mGILibConstLab_Fridge = payload.value;
            _context.MGILibConstLab_Fridge.Add(mGILibConstLab_Fridge);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Fridge);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_Fridge> payload)
        {
            MGILibConstLab_Fridge mGILibConstLab_Fridge = payload.value;
            _context.MGILibConstLab_Fridge.Update(mGILibConstLab_Fridge);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Fridge);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_Fridge> payload)
        {
            MGILibConstLab_Fridge mGILibConstLab_Fridge = _context.MGILibConstLab_Fridge
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_Fridge.Remove(mGILibConstLab_Fridge);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Fridge);

        }
    }
}