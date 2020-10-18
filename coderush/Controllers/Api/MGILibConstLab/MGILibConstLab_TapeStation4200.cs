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
    [Route("api/MGILibConstLab_TapeStation4200")]
    public class MGILibConstLab_TapeStation4200Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_TapeStation4200Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_TapeStation4200
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_TapeStation4200()
        {
            List<MGILibConstLab_TapeStation4200> Items = await _context.MGILibConstLab_TapeStation4200.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_TapeStation4200> payload)
        {
            MGILibConstLab_TapeStation4200 mGILibConstLab_TapeStation4200 = payload.value;
            _context.MGILibConstLab_TapeStation4200.Add(mGILibConstLab_TapeStation4200);
            _context.SaveChanges();
            return Ok(mGILibConstLab_TapeStation4200);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_TapeStation4200> payload)
        {
            MGILibConstLab_TapeStation4200 mGILibConstLab_TapeStation4200 = payload.value;
            _context.MGILibConstLab_TapeStation4200.Update(mGILibConstLab_TapeStation4200);
            _context.SaveChanges();
            return Ok(mGILibConstLab_TapeStation4200);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_TapeStation4200> payload)
        {
            MGILibConstLab_TapeStation4200 mGILibConstLab_TapeStation4200 = _context.MGILibConstLab_TapeStation4200
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_TapeStation4200.Remove(mGILibConstLab_TapeStation4200);
            _context.SaveChanges();
            return Ok(mGILibConstLab_TapeStation4200);

        }
    }
}