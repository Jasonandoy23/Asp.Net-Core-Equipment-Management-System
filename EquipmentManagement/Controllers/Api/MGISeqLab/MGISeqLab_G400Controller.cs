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
    [Route("api/MGISeqLab_G400")]
    public class MGISeqLab_G400Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_G400Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_G400
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_G400()
        {
            List<MGISeqLab_G400> Items = await _context.MGISeqLab_G400.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_G400> payload)
        {
            MGISeqLab_G400 mGISeqLab_G400 = payload.value;
            _context.MGISeqLab_G400.Add(mGISeqLab_G400);
            _context.SaveChanges();
            return Ok(mGISeqLab_G400);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_G400> payload)
        {
            MGISeqLab_G400 mGISeqLab_G400 = payload.value;
            _context.MGISeqLab_G400.Update(mGISeqLab_G400);
            _context.SaveChanges();
            return Ok(mGISeqLab_G400);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_G400> payload)
        {
            MGISeqLab_G400 mGISeqLab_G400 = _context.MGISeqLab_G400
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_G400.Remove(mGISeqLab_G400);
            _context.SaveChanges();
            return Ok(mGISeqLab_G400);

        }
    }
}