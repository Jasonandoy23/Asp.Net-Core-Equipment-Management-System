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
    [Route("api/BSLSamMgmt_ESCOClassIITypeA2")]
    public class BSLSamMgmt_ESCOClassIITypeA2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_ESCOClassIITypeA2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_ESCOClassIITypeA2
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_ESCOClassIITypeA2()
        {
            List<BSLSamMgmt_ESCOClassIITypeA2> Items = await _context.BSLSamMgmt_ESCOClassIITypeA2.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_ESCOClassIITypeA2> payload)
        {
            BSLSamMgmt_ESCOClassIITypeA2 bSLSamMgmt_ESCOClassIITypeA2 = payload.value;
            _context.BSLSamMgmt_ESCOClassIITypeA2.Add(bSLSamMgmt_ESCOClassIITypeA2);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_ESCOClassIITypeA2);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_ESCOClassIITypeA2> payload)
        {
            BSLSamMgmt_ESCOClassIITypeA2 bSLSamMgmt_ESCOClassIITypeA2 = payload.value;
            _context.BSLSamMgmt_ESCOClassIITypeA2.Update(bSLSamMgmt_ESCOClassIITypeA2);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_ESCOClassIITypeA2);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_ESCOClassIITypeA2> payload)
        {
            BSLSamMgmt_ESCOClassIITypeA2 bSLSamMgmt_ESCOClassIITypeA2 = _context.BSLSamMgmt_ESCOClassIITypeA2
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_ESCOClassIITypeA2.Remove(bSLSamMgmt_ESCOClassIITypeA2);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_ESCOClassIITypeA2);

        }
    }
}