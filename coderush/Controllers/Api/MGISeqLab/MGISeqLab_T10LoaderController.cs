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
    [Route("api/MGISeqLab_T10Loader")]
    public class MGISeqLab_T10LoaderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_T10LoaderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_T10Loader
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_T10Loader()
        {
            List<MGISeqLab_T10Loader> Items = await _context.MGISeqLab_T10Loader.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_T10Loader> payload)
        {
            MGISeqLab_T10Loader mGISeqLab_T10Loader = payload.value;
            _context.MGISeqLab_T10Loader.Add(mGISeqLab_T10Loader);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10Loader);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_T10Loader> payload)
        {
            MGISeqLab_T10Loader mGISeqLab_T10Loader = payload.value;
            _context.MGISeqLab_T10Loader.Update(mGISeqLab_T10Loader);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10Loader);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_T10Loader> payload)
        {
            MGISeqLab_T10Loader mGISeqLab_T10Loader = _context.MGISeqLab_T10Loader
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_T10Loader.Remove(mGISeqLab_T10Loader);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10Loader);

        }
    }
}