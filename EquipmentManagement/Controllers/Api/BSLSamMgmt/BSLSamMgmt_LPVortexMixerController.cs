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
    [Route("api/BSLSamMgmt_LPVortexMixer")]
    public class BSLSamMgmt_LPVortexMixerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_LPVortexMixerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_LPVortexMixer
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_LPVortexMixer()
        {
            List<BSLSamMgmt_LPVortexMixer> Items = await _context.BSLSamMgmt_LPVortexMixer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_LPVortexMixer> payload)
        {
            BSLSamMgmt_LPVortexMixer bSLSamMgmt_LPVortexMixer = payload.value;
            _context.BSLSamMgmt_LPVortexMixer.Add(bSLSamMgmt_LPVortexMixer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_LPVortexMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_LPVortexMixer> payload)
        {
            BSLSamMgmt_LPVortexMixer bSLSamMgmt_LPVortexMixer = payload.value;
            _context.BSLSamMgmt_LPVortexMixer.Update(bSLSamMgmt_LPVortexMixer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_LPVortexMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_LPVortexMixer> payload)
        {
            BSLSamMgmt_LPVortexMixer bSLSamMgmt_LPVortexMixer = _context.BSLSamMgmt_LPVortexMixer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_LPVortexMixer.Remove(bSLSamMgmt_LPVortexMixer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_LPVortexMixer);

        }
    }
}