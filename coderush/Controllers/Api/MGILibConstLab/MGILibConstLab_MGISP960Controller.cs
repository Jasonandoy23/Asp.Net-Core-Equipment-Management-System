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
    [Route("api/MGILibConstLab_MGISP960")]
    public class MGILibConstLab_MGISP960Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_MGISP960Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_MGISP960
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_MGISP960()
        {
            List<MGILibConstLab_MGISP960> Items = await _context.MGILibConstLab_MGISP960.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_MGISP960> payload)
        {
            MGILibConstLab_MGISP960 mGILibConstLab_MGISP960 = payload.value;
            _context.MGILibConstLab_MGISP960.Add(mGILibConstLab_MGISP960);
            _context.SaveChanges();
            return Ok(mGILibConstLab_MGISP960);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_MGISP960> payload)
        {
            MGILibConstLab_MGISP960 mGILibConstLab_MGISP960 = payload.value;
            _context.MGILibConstLab_MGISP960.Update(mGILibConstLab_MGISP960);
            _context.SaveChanges();
            return Ok(mGILibConstLab_MGISP960);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_MGISP960> payload)
        {
            MGILibConstLab_MGISP960 mGILibConstLab_MGISP960 = _context.MGILibConstLab_MGISP960
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_MGISP960.Remove(mGILibConstLab_MGISP960);
            _context.SaveChanges();
            return Ok(mGILibConstLab_MGISP960);

        }
    }
}