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
    [Route("api/MGILibConstLab_Vortexer")]
    public class MGILibConstLab_VortexerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_VortexerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_Vortexer
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_Vortexer()
        {
            List<MGILibConstLab_Vortexer> Items = await _context.MGILibConstLab_Vortexer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_Vortexer> payload)
        {
            MGILibConstLab_Vortexer mGILibConstLab_Vortexer = payload.value;
            _context.MGILibConstLab_Vortexer.Add(mGILibConstLab_Vortexer);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Vortexer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_Vortexer> payload)
        {
            MGILibConstLab_Vortexer mGILibConstLab_Vortexer = payload.value;
            _context.MGILibConstLab_Vortexer.Update(mGILibConstLab_Vortexer);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Vortexer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_Vortexer> payload)
        {
            MGILibConstLab_Vortexer mGILibConstLab_Vortexer = _context.MGILibConstLab_Vortexer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_Vortexer.Remove(mGILibConstLab_Vortexer);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Vortexer);

        }
    }
}