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
    [Route("api/BSLDNAExt_NanoPhotometer")]
    public class BSLDNAExt_NanoPhotometerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_NanoPhotometerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_NanoPhotometer
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_NanoPhotometer()
        {
            List<BSLDNAExt_NanoPhotometer> Items = await _context.BSLDNAExt_NanoPhotometer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_NanoPhotometer> payload)
        {
            BSLDNAExt_NanoPhotometer bSLDNAExt_NanoPhotometer = payload.value;
            _context.BSLDNAExt_NanoPhotometer.Add(bSLDNAExt_NanoPhotometer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_NanoPhotometer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_NanoPhotometer> payload)
        {
            BSLDNAExt_NanoPhotometer bSLDNAExt_NanoPhotometer = payload.value;
            _context.BSLDNAExt_NanoPhotometer.Update(bSLDNAExt_NanoPhotometer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_NanoPhotometer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_NanoPhotometer> payload)
        {
            BSLDNAExt_NanoPhotometer bSLDNAExt_NanoPhotometer = _context.BSLDNAExt_NanoPhotometer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_NanoPhotometer.Remove(bSLDNAExt_NanoPhotometer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_NanoPhotometer);

        }
    }
}