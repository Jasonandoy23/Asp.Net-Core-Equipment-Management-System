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
    [Route("api/BSLSamMgmt_BioSafetyCabinet")]
    public class BSLSamMgmt_BioSafetyCabinetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_BioSafetyCabinetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_BioSafetyCabinet
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_BioSafetyCabinet()
        {
            List<BSLSamMgmt_BioSafetyCabinet> Items = await _context.BSLSamMgmt_BioSafetyCabinet.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_BioSafetyCabinet> payload)
        {
            BSLSamMgmt_BioSafetyCabinet bSLSamMgmt_BioSafetyCabinet = payload.value;
            _context.BSLSamMgmt_BioSafetyCabinet.Add(bSLSamMgmt_BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_BioSafetyCabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_BioSafetyCabinet> payload)
        {
            BSLSamMgmt_BioSafetyCabinet bSLSamMgmt_BioSafetyCabinet = payload.value;
            _context.BSLSamMgmt_BioSafetyCabinet.Update(bSLSamMgmt_BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_BioSafetyCabinet);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_BioSafetyCabinet> payload)
        {
            BSLSamMgmt_BioSafetyCabinet bSLSamMgmt_BioSafetyCabinet = _context.BSLSamMgmt_BioSafetyCabinet
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_BioSafetyCabinet.Remove(bSLSamMgmt_BioSafetyCabinet);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_BioSafetyCabinet);

        }
    }
}