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
    [Route("api/BSLDNAExt_HeatSealer")]
    public class BSLDNAExt_HeatSealerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_HeatSealerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_HeatSealer
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_HeatSealer()
        {
            List<BSLDNAExt_HeatSealer> Items = await _context.BSLDNAExt_HeatSealer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_HeatSealer> payload)
        {
            BSLDNAExt_HeatSealer bSLDNAExt_HeatSealer = payload.value;
            _context.BSLDNAExt_HeatSealer.Add(bSLDNAExt_HeatSealer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HeatSealer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_HeatSealer> payload)
        {
            BSLDNAExt_HeatSealer bSLDNAExt_HeatSealer = payload.value;
            _context.BSLDNAExt_HeatSealer.Update(bSLDNAExt_HeatSealer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HeatSealer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_HeatSealer> payload)
        {
            BSLDNAExt_HeatSealer bSLDNAExt_HeatSealer = _context.BSLDNAExt_HeatSealer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_HeatSealer.Remove(bSLDNAExt_HeatSealer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HeatSealer);

        }
    }
}