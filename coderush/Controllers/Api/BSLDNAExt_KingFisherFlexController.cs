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
    [Route("api/BSLDNAExt_KingFisherFlex")]
    public class BSLDNAExt_KingFisherFlexController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_KingFisherFlexController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_KingFisherFlex
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_KingFisherFlex()
        {
            List<BSLDNAExt_KingFisherFlex> Items = await _context.BSLDNAExt_KingFisherFlex.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_KingFisherFlex> payload)
        {
            BSLDNAExt_KingFisherFlex bSLDNAExt_KingFisherFlex = payload.value;
            _context.BSLDNAExt_KingFisherFlex.Add(bSLDNAExt_KingFisherFlex);
            _context.SaveChanges();
            return Ok(bSLDNAExt_KingFisherFlex);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_KingFisherFlex> payload)
        {
            BSLDNAExt_KingFisherFlex bSLDNAExt_KingFisherFlex = payload.value;
            _context.BSLDNAExt_KingFisherFlex.Update(bSLDNAExt_KingFisherFlex);
            _context.SaveChanges();
            return Ok(bSLDNAExt_KingFisherFlex);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_KingFisherFlex> payload)
        {
            BSLDNAExt_KingFisherFlex bSLDNAExt_KingFisherFlex = _context.BSLDNAExt_KingFisherFlex
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_KingFisherFlex.Remove(bSLDNAExt_KingFisherFlex);
            _context.SaveChanges();
            return Ok(bSLDNAExt_KingFisherFlex);

        }
    }
}