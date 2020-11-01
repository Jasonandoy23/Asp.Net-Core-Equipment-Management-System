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
    [Route("api/RDLab_ESCOClassIITypeA2BioSafetyCabinet")]
    public class RDLab_ESCOClassIITypeA2BioSafetyCabinetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_ESCOClassIITypeA2BioSafetyCabinetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_ESCOClassIITypeA2BioSafetyCabinet
        [HttpGet]
        public async Task<IActionResult> GetRDLab_ESCOClassIITypeA2BioSafetyCabinet()
        {
            List<RDLab_ESCOClassIITypeA2BioSafetyCabinet> Items = await _context.RDLab_ESCOClassIITypeA2BioSafetyCabinet.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_ESCOClassIITypeA2BioSafetyCabinet> payload)
        {
            RDLab_ESCOClassIITypeA2BioSafetyCabinet rDLab_ESCOClassIITypeA2BioSafetyCabinet = payload.value;
            _context.RDLab_ESCOClassIITypeA2BioSafetyCabinet.Add(rDLab_ESCOClassIITypeA2BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(rDLab_ESCOClassIITypeA2BioSafetyCabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_ESCOClassIITypeA2BioSafetyCabinet> payload)
        {
            RDLab_ESCOClassIITypeA2BioSafetyCabinet rDLab_ESCOClassIITypeA2BioSafetyCabinet = payload.value;
            _context.RDLab_ESCOClassIITypeA2BioSafetyCabinet.Update(rDLab_ESCOClassIITypeA2BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(rDLab_ESCOClassIITypeA2BioSafetyCabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_ESCOClassIITypeA2BioSafetyCabinet> payload)
        {
            RDLab_ESCOClassIITypeA2BioSafetyCabinet rDLab_ESCOClassIITypeA2BioSafetyCabinet = _context.RDLab_ESCOClassIITypeA2BioSafetyCabinet
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_ESCOClassIITypeA2BioSafetyCabinet.Remove(rDLab_ESCOClassIITypeA2BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(rDLab_ESCOClassIITypeA2BioSafetyCabinet);

        }
    }
}