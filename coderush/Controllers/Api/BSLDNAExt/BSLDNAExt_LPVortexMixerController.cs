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
    [Route("api/BSLDNAExt_LPVortexMixer")]
    public class BSLDNAExt_LPVortexMixerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_LPVortexMixerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_LPVortexMixer
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_LPVortexMixer()
        {
            List<BSLDNAExt_LPVortexMixer> Items = await _context.BSLDNAExt_LPVortexMixer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_LPVortexMixer> payload)
        {
            BSLDNAExt_LPVortexMixer bSLDNAExt_LPVortexMixer = payload.value;
            _context.BSLDNAExt_LPVortexMixer.Add(bSLDNAExt_LPVortexMixer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_LPVortexMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_LPVortexMixer> payload)
        {
            BSLDNAExt_LPVortexMixer bSLDNAExt_LPVortexMixer = payload.value;
            _context.BSLDNAExt_LPVortexMixer.Update(bSLDNAExt_LPVortexMixer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_LPVortexMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_LPVortexMixer> payload)
        {
            BSLDNAExt_LPVortexMixer bSLDNAExt_LPVortexMixer = _context.BSLDNAExt_LPVortexMixer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_LPVortexMixer.Remove(bSLDNAExt_LPVortexMixer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_LPVortexMixer);

        }
    }
}