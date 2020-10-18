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
    [Route("api/MGILibConstLab_Centrifuge5810R")]
    public class MGILibConstLab_Centrifuge5810RController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_Centrifuge5810RController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_Centrifuge5810R
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_Centrifuge5810R()
        {
            List<MGILibConstLab_Centrifuge5810R> Items = await _context.MGILibConstLab_Centrifuge5810R.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_Centrifuge5810R> payload)
        {
            MGILibConstLab_Centrifuge5810R mGILibConstLab_Centrifuge5810R = payload.value;
            _context.MGILibConstLab_Centrifuge5810R.Add(mGILibConstLab_Centrifuge5810R);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Centrifuge5810R);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_Centrifuge5810R> payload)
        {
            MGILibConstLab_Centrifuge5810R mGILibConstLab_Centrifuge5810R = payload.value;
            _context.MGILibConstLab_Centrifuge5810R.Update(mGILibConstLab_Centrifuge5810R);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Centrifuge5810R);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_Centrifuge5810R> payload)
        {
            MGILibConstLab_Centrifuge5810R mGILibConstLab_Centrifuge5810R = _context.MGILibConstLab_Centrifuge5810R
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_Centrifuge5810R.Remove(mGILibConstLab_Centrifuge5810R);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Centrifuge5810R);

        }
    }
}