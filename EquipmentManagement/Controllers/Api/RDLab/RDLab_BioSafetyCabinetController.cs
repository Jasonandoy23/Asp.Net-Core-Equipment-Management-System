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
    [Route("api/RDLab_BioSafetyCabinet")]
    public class RDLab_BioSafetyCabinetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_BioSafetyCabinetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_BioSafetyCabinet
        [HttpGet]
        public async Task<IActionResult> GetRDLab_BioSafetyCabinet()
        {
            List<RDLab_BioSafetyCabinet> Items = await _context.RDLab_BioSafetyCabinet.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_BioSafetyCabinet> payload)
        {
            RDLab_BioSafetyCabinet rDLab_BioSafetyCabinet = payload.value;
            _context.RDLab_BioSafetyCabinet.Add(rDLab_BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(rDLab_BioSafetyCabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_BioSafetyCabinet> payload)
        {
            RDLab_BioSafetyCabinet rDLab_BioSafetyCabinet = payload.value;
            _context.RDLab_BioSafetyCabinet.Update(rDLab_BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(rDLab_BioSafetyCabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_BioSafetyCabinet> payload)
        {
            RDLab_BioSafetyCabinet rDLab_BioSafetyCabinet = _context.RDLab_BioSafetyCabinet
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_BioSafetyCabinet.Remove(rDLab_BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(rDLab_BioSafetyCabinet);

        }
    }
}