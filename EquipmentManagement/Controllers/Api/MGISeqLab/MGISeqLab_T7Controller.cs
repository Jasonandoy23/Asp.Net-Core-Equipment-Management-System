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
    [Route("api/MGISeqLab_T7")]
    public class MGISeqLab_T7Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_T7Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_T7
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_T7()
        {
            List<MGISeqLab_T7> Items = await _context.MGISeqLab_T7.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_T7> payload)
        {
            MGISeqLab_T7 mGISeqLab_T7 = payload.value;
            _context.MGISeqLab_T7.Add(mGISeqLab_T7);
            _context.SaveChanges();
            return Ok(mGISeqLab_T7);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_T7> payload)
        {
            MGISeqLab_T7 mGISeqLab_T7 = payload.value;
            _context.MGISeqLab_T7.Update(mGISeqLab_T7);
            _context.SaveChanges();
            return Ok(mGISeqLab_T7);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_T7> payload)
        {
            MGISeqLab_T7 mGISeqLab_T7 = _context.MGISeqLab_T7
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_T7.Remove(mGISeqLab_T7);
            _context.SaveChanges();
            return Ok(mGISeqLab_T7);

        }
    }
}