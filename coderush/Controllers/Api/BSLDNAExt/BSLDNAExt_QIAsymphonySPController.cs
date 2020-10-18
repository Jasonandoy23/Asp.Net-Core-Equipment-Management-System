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
    [Route("api/BSLDNAExt_QIAsymphonySP")]
    public class BSLDNAExt_QIAsymphonySPController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_QIAsymphonySPController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_QIAsymphonySP
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_QIAsymphonySP()
        {
            List<BSLDNAExt_QIAsymphonySP> Items = await _context.BSLDNAExt_QIAsymphonySP.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_QIAsymphonySP> payload)
        {
            BSLDNAExt_QIAsymphonySP bSLDNAExt_QIAsymphonySP = payload.value;
            _context.BSLDNAExt_QIAsymphonySP.Add(bSLDNAExt_QIAsymphonySP);
            _context.SaveChanges();
            return Ok(bSLDNAExt_QIAsymphonySP);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_QIAsymphonySP> payload)
        {
            BSLDNAExt_QIAsymphonySP bSLDNAExt_QIAsymphonySP = payload.value;
            _context.BSLDNAExt_QIAsymphonySP.Update(bSLDNAExt_QIAsymphonySP);
            _context.SaveChanges();
            return Ok(bSLDNAExt_QIAsymphonySP);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_QIAsymphonySP> payload)
        {
            BSLDNAExt_QIAsymphonySP bSLDNAExt_QIAsymphonySP = _context.BSLDNAExt_QIAsymphonySP
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_QIAsymphonySP.Remove(bSLDNAExt_QIAsymphonySP);
            _context.SaveChanges();
            return Ok(bSLDNAExt_QIAsymphonySP);

        }
    }
}