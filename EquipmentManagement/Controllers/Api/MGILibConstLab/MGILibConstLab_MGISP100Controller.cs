using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using EquipmentManagement.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace EquipmentManagement.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/MGILibConstLab_MGISP100")]
    public class MGILibConstLab_MGISP100Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_MGISP100Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_MGISP100
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_MGISP100()
        {
            List<MGILibConstLab_MGISP100> Items = await _context.MGILibConstLab_MGISP100.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_MGISP100> payload)
        {
            MGILibConstLab_MGISP100 mGILibConstLab_MGISP100 = payload.value;
            _context.MGILibConstLab_MGISP100.Add(mGILibConstLab_MGISP100);
            _context.SaveChanges();
            return Ok(mGILibConstLab_MGISP100);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_MGISP100> payload)
        {
            MGILibConstLab_MGISP100 mGILibConstLab_MGISP100 = payload.value;
            _context.MGILibConstLab_MGISP100.Update(mGILibConstLab_MGISP100);
            _context.SaveChanges();
            return Ok(mGILibConstLab_MGISP100);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_MGISP100> payload)
        {
            MGILibConstLab_MGISP100 mGILibConstLab_MGISP100 = _context.MGILibConstLab_MGISP100
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_MGISP100.Remove(mGILibConstLab_MGISP100);
            _context.SaveChanges();
            return Ok(mGILibConstLab_MGISP100);

        }
    }
}