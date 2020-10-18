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
    [Route("api/MGISeqLab_T7Loader")]
    public class MGISeqLab_T7LoaderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_T7LoaderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_T7Loader
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_T7Loader()
        {
            List<MGISeqLab_T7Loader> Items = await _context.MGISeqLab_T7Loader.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_T7Loader> payload)
        {
            MGISeqLab_T7Loader mGISeqLab_T7Loader = payload.value;
            _context.MGISeqLab_T7Loader.Add(mGISeqLab_T7Loader);
            _context.SaveChanges();
            return Ok(mGISeqLab_T7Loader);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_T7Loader> payload)
        {
            MGISeqLab_T7Loader mGISeqLab_T7Loader = payload.value;
            _context.MGISeqLab_T7Loader.Update(mGISeqLab_T7Loader);
            _context.SaveChanges();
            return Ok(mGISeqLab_T7Loader);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_T7Loader> payload)
        {
            MGISeqLab_T7Loader mGISeqLab_T7Loader = _context.MGISeqLab_T7Loader
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_T7Loader.Remove(mGISeqLab_T7Loader);
            _context.SaveChanges();
            return Ok(mGISeqLab_T7Loader);

        }
    }
}