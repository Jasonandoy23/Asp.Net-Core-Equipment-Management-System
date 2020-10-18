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
    [Route("api/MGISeqLab_Freezer")]
    public class MGISeqLab_FreezerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_FreezerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_Freezer
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_Freezer()
        {
            List<MGISeqLab_Freezer> Items = await _context.MGISeqLab_Freezer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_Freezer> payload)
        {
            MGISeqLab_Freezer mGISeqLab_Freezer = payload.value;
            _context.MGISeqLab_Freezer.Add(mGISeqLab_Freezer);
            _context.SaveChanges();
            return Ok(mGISeqLab_Freezer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_Freezer> payload)
        {
            MGISeqLab_Freezer mGISeqLab_Freezer = payload.value;
            _context.MGISeqLab_Freezer.Update(mGISeqLab_Freezer);
            _context.SaveChanges();
            return Ok(mGISeqLab_Freezer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_Freezer> payload)
        {
            MGISeqLab_Freezer mGISeqLab_Freezer = _context.MGISeqLab_Freezer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_Freezer.Remove(mGISeqLab_Freezer);
            _context.SaveChanges();
            return Ok(mGISeqLab_Freezer);

        }
    }
}