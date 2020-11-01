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
    [Route("api/BSLDNAExt_PerkinElmerJanusG3")]
    public class BSLDNAExt_PerkinElmerJanusG3Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_PerkinElmerJanusG3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_PerkinElmerJanusG3
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_PerkinElmerJanusG3()
        {
            List<BSLDNAExt_PerkinElmerJanusG3> Items = await _context.BSLDNAExt_PerkinElmerJanusG3.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_PerkinElmerJanusG3> payload)
        {
            BSLDNAExt_PerkinElmerJanusG3 bSLDNAExt_PerkinElmerJanusG3 = payload.value;
            _context.BSLDNAExt_PerkinElmerJanusG3.Add(bSLDNAExt_PerkinElmerJanusG3);
            _context.SaveChanges();
            return Ok(bSLDNAExt_PerkinElmerJanusG3);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_PerkinElmerJanusG3> payload)
        {
            BSLDNAExt_PerkinElmerJanusG3 bSLDNAExt_PerkinElmerJanusG3 = payload.value;
            _context.BSLDNAExt_PerkinElmerJanusG3.Update(bSLDNAExt_PerkinElmerJanusG3);
            _context.SaveChanges();
            return Ok(bSLDNAExt_PerkinElmerJanusG3);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_PerkinElmerJanusG3> payload)
        {
            BSLDNAExt_PerkinElmerJanusG3 bSLDNAExt_PerkinElmerJanusG3 = _context.BSLDNAExt_PerkinElmerJanusG3
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_PerkinElmerJanusG3.Remove(bSLDNAExt_PerkinElmerJanusG3);
            _context.SaveChanges();
            return Ok(bSLDNAExt_PerkinElmerJanusG3);

        }
    }
}