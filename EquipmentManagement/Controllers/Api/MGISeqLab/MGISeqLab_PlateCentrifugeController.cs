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
    [Route("api/MGISeqLab_PlateCentrifuge")]
    public class MGISeqLab_PlateCentrifugeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_PlateCentrifugeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_PlateCentrifuge
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_PlateCentrifuge()
        {
            List<MGISeqLab_PlateCentrifuge> Items = await _context.MGISeqLab_PlateCentrifuge.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_PlateCentrifuge> payload)
        {
            MGISeqLab_PlateCentrifuge mGISeqLab_PlateCentrifuge = payload.value;
            _context.MGISeqLab_PlateCentrifuge.Add(mGISeqLab_PlateCentrifuge);
            _context.SaveChanges();
            return Ok(mGISeqLab_PlateCentrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_PlateCentrifuge> payload)
        {
            MGISeqLab_PlateCentrifuge mGISeqLab_PlateCentrifuge = payload.value;
            _context.MGISeqLab_PlateCentrifuge.Update(mGISeqLab_PlateCentrifuge);
            _context.SaveChanges();
            return Ok(mGISeqLab_PlateCentrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_PlateCentrifuge> payload)
        {
            MGISeqLab_PlateCentrifuge mGISeqLab_PlateCentrifuge = _context.MGISeqLab_PlateCentrifuge
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_PlateCentrifuge.Remove(mGISeqLab_PlateCentrifuge);
            _context.SaveChanges();
            return Ok(mGISeqLab_PlateCentrifuge);

        }
    }
}