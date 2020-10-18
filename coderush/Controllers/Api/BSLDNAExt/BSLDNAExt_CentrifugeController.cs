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
    [Route("api/BSLDNAExt_Centrifuge")]
    public class BSLDNAExt_CentrifugeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_CentrifugeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_Centrifuge
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_Centrifuge()
        {
            List<BSLDNAExt_Centrifuge> Items = await _context.BSLDNAExt_Centrifuge.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_Centrifuge> payload)
        {
            BSLDNAExt_Centrifuge bSLDNAExt_Centrifuge = payload.value;
            _context.BSLDNAExt_Centrifuge.Add(bSLDNAExt_Centrifuge);
            _context.SaveChanges();
            return Ok(bSLDNAExt_Centrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_Centrifuge> payload)
        {
            BSLDNAExt_Centrifuge bSLDNAExt_Centrifuge = payload.value;
            _context.BSLDNAExt_Centrifuge.Update(bSLDNAExt_Centrifuge);
            _context.SaveChanges();
            return Ok(bSLDNAExt_Centrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_Centrifuge> payload)
        {
            BSLDNAExt_Centrifuge bSLDNAExt_Centrifuge = _context.BSLDNAExt_Centrifuge
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_Centrifuge.Remove(bSLDNAExt_Centrifuge);
            _context.SaveChanges();
            return Ok(bSLDNAExt_Centrifuge);

        }
    }
}