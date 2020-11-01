using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using EquipmentManagement.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace EquipmentManagement.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/RDLab_LPVortexMixer")]
    public class RDLab_LPVortexMixerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_LPVortexMixerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_LPVortexMixer
        [HttpGet]
        public async Task<IActionResult> GetRDLab_LPVortexMixer()
        {
            List<RDLab_LPVortexMixer> Items = await _context.RDLab_LPVortexMixer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_LPVortexMixer> payload)
        {
            RDLab_LPVortexMixer rDLab_LPVortexMixer = payload.value;
            _context.RDLab_LPVortexMixer.Add(rDLab_LPVortexMixer);
            _context.SaveChanges();
            return Ok(rDLab_LPVortexMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_LPVortexMixer> payload)
        {
            RDLab_LPVortexMixer rDLab_LPVortexMixer = payload.value;
            _context.RDLab_LPVortexMixer.Update(rDLab_LPVortexMixer);
            _context.SaveChanges();
            return Ok(rDLab_LPVortexMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_LPVortexMixer> payload)
        {
            RDLab_LPVortexMixer rDLab_LPVortexMixer = _context.RDLab_LPVortexMixer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_LPVortexMixer.Remove(rDLab_LPVortexMixer);
            _context.SaveChanges();
            return Ok(rDLab_LPVortexMixer);

        }
    }
}