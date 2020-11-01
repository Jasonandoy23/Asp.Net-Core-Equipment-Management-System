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
    [Route("api/BSLDNAExt_PerkinElmerChemagic360")]
    public class BSLDNAExt_PerkinElmerChemagic360Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_PerkinElmerChemagic360Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_PerkinElmerChemagic360
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_PerkinElmerChemagic360()
        {
            List<BSLDNAExt_PerkinElmerChemagic360> Items = await _context.BSLDNAExt_PerkinElmerChemagic360.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_PerkinElmerChemagic360> payload)
        {
            BSLDNAExt_PerkinElmerChemagic360 bSLDNAExt_PerkinElmerChemagic360 = payload.value;
            _context.BSLDNAExt_PerkinElmerChemagic360.Add(bSLDNAExt_PerkinElmerChemagic360);
            _context.SaveChanges();
            return Ok(bSLDNAExt_PerkinElmerChemagic360);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_PerkinElmerChemagic360> payload)
        {
            BSLDNAExt_PerkinElmerChemagic360 bSLDNAExt_PerkinElmerChemagic360 = payload.value;
            _context.BSLDNAExt_PerkinElmerChemagic360.Update(bSLDNAExt_PerkinElmerChemagic360);
            _context.SaveChanges();
            return Ok(bSLDNAExt_PerkinElmerChemagic360);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_PerkinElmerChemagic360> payload)
        {
            BSLDNAExt_PerkinElmerChemagic360 bSLDNAExt_PerkinElmerChemagic360 = _context.BSLDNAExt_PerkinElmerChemagic360
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_PerkinElmerChemagic360.Remove(bSLDNAExt_PerkinElmerChemagic360);
            _context.SaveChanges();
            return Ok(bSLDNAExt_PerkinElmerChemagic360);

        }
    }
}