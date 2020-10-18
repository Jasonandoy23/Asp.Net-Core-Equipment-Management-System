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
    [Route("api/MGISeqLab_T10OpticalPlatformPart")]
    public class MGISeqLab_T10OpticalPlatformPartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_T10OpticalPlatformPartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_T10OpticalPlatformPart
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_T10OpticalPlatformPart()
        {
            List<MGISeqLab_T10OpticalPlatformPart> Items = await _context.MGISeqLab_T10OpticalPlatformPart.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_T10OpticalPlatformPart> payload)
        {
            MGISeqLab_T10OpticalPlatformPart mGISeqLab_T10OpticalPlatformPart = payload.value;
            _context.MGISeqLab_T10OpticalPlatformPart.Add(mGISeqLab_T10OpticalPlatformPart);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10OpticalPlatformPart);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_T10OpticalPlatformPart> payload)
        {
            MGISeqLab_T10OpticalPlatformPart mGISeqLab_T10OpticalPlatformPart = payload.value;
            _context.MGISeqLab_T10OpticalPlatformPart.Update(mGISeqLab_T10OpticalPlatformPart);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10OpticalPlatformPart);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_T10OpticalPlatformPart> payload)
        {
            MGISeqLab_T10OpticalPlatformPart mGISeqLab_T10OpticalPlatformPart = _context.MGISeqLab_T10OpticalPlatformPart
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_T10OpticalPlatformPart.Remove(mGISeqLab_T10OpticalPlatformPart);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10OpticalPlatformPart);

        }
    }
}