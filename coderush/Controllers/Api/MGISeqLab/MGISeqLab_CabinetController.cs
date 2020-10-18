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
    [Route("api/MGISeqLab_Cabinet")]
    public class MGISeqLab_CabinetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_CabinetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_Cabinet
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_Cabinet()
        {
            List<MGISeqLab_Cabinet> Items = await _context.MGISeqLab_Cabinet.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_Cabinet> payload)
        {
            MGISeqLab_Cabinet mGISeqLab_Cabinet = payload.value;
            _context.MGISeqLab_Cabinet.Add(mGISeqLab_Cabinet);
            _context.SaveChanges();
            return Ok(mGISeqLab_Cabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_Cabinet> payload)
        {
            MGISeqLab_Cabinet mGISeqLab_Cabinet = payload.value;
            _context.MGISeqLab_Cabinet.Update(mGISeqLab_Cabinet);
            _context.SaveChanges();
            return Ok(mGISeqLab_Cabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_Cabinet> payload)
        {
            MGISeqLab_Cabinet mGISeqLab_Cabinet = _context.MGISeqLab_Cabinet
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_Cabinet.Remove(mGISeqLab_Cabinet);
            _context.SaveChanges();
            return Ok(mGISeqLab_Cabinet);

        }
    }
}