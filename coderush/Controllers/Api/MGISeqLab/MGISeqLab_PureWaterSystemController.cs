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
    [Route("api/MGISeqLab_PureWaterSystem")]
    public class MGISeqLab_PureWaterSystemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_PureWaterSystemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_PureWaterSystem
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_PureWaterSystem()
        {
            List<MGISeqLab_PureWaterSystem> Items = await _context.MGISeqLab_PureWaterSystem.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_PureWaterSystem> payload)
        {
            MGISeqLab_PureWaterSystem mGISeqLab_PureWaterSystem = payload.value;
            _context.MGISeqLab_PureWaterSystem.Add(mGISeqLab_PureWaterSystem);
            _context.SaveChanges();
            return Ok(mGISeqLab_PureWaterSystem);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_PureWaterSystem> payload)
        {
            MGISeqLab_PureWaterSystem mGISeqLab_PureWaterSystem = payload.value;
            _context.MGISeqLab_PureWaterSystem.Update(mGISeqLab_PureWaterSystem);
            _context.SaveChanges();
            return Ok(mGISeqLab_PureWaterSystem);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_PureWaterSystem> payload)
        {
            MGISeqLab_PureWaterSystem mGISeqLab_PureWaterSystem = _context.MGISeqLab_PureWaterSystem
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_PureWaterSystem.Remove(mGISeqLab_PureWaterSystem);
            _context.SaveChanges();
            return Ok(mGISeqLab_PureWaterSystem);

        }
    }
}