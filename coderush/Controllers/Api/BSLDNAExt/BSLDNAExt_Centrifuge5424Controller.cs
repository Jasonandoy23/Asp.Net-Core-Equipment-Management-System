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
    [Route("api/BSLDNAExt_Centrifuge5424")]
    public class BSLDNAExt_Centrifuge5424Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_Centrifuge5424Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_Centrifuge5424
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_Centrifuge5424()
        {
            List<BSLDNAExt_Centrifuge5424> Items = await _context.BSLDNAExt_Centrifuge5424.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_Centrifuge5424> payload)
        {
            BSLDNAExt_Centrifuge5424 bSLDNAExt_Centrifuge5424 = payload.value;
            _context.BSLDNAExt_Centrifuge5424.Add(bSLDNAExt_Centrifuge5424);
            _context.SaveChanges();
            return Ok(bSLDNAExt_Centrifuge5424);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_Centrifuge5424> payload)
        {
            BSLDNAExt_Centrifuge5424 bSLDNAExt_Centrifuge5424 = payload.value;
            _context.BSLDNAExt_Centrifuge5424.Update(bSLDNAExt_Centrifuge5424);
            _context.SaveChanges();
            return Ok(bSLDNAExt_Centrifuge5424);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_Centrifuge5424> payload)
        {
            BSLDNAExt_Centrifuge5424 bSLDNAExt_Centrifuge5424 = _context.BSLDNAExt_Centrifuge5424
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_Centrifuge5424.Remove(bSLDNAExt_Centrifuge5424);
            _context.SaveChanges();
            return Ok(bSLDNAExt_Centrifuge5424);

        }
    }
}