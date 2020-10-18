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
    [Route("api/MGISeqLab_Refrigerator")]
    public class MGISeqLab_RefrigeratorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_RefrigeratorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_Refrigerator
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_Refrigerator()
        {
            List<MGISeqLab_Refrigerator> Items = await _context.MGISeqLab_Refrigerator.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_Refrigerator> payload)
        {
            MGISeqLab_Refrigerator mGISeqLab_Refrigerator = payload.value;
            _context.MGISeqLab_Refrigerator.Add(mGISeqLab_Refrigerator);
            _context.SaveChanges();
            return Ok(mGISeqLab_Refrigerator);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_Refrigerator> payload)
        {
            MGISeqLab_Refrigerator mGISeqLab_Refrigerator = payload.value;
            _context.MGISeqLab_Refrigerator.Update(mGISeqLab_Refrigerator);
            _context.SaveChanges();
            return Ok(mGISeqLab_Refrigerator);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_Refrigerator> payload)
        {
            MGISeqLab_Refrigerator mGISeqLab_Refrigerator = _context.MGISeqLab_Refrigerator
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_Refrigerator.Remove(mGISeqLab_Refrigerator);
            _context.SaveChanges();
            return Ok(mGISeqLab_Refrigerator);

        }
    }
}