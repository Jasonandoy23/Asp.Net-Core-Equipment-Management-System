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
    [Route("api/BSLDNAExt_HaierHYC")]
    public class BSLDNAExt_HaierHYCController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_HaierHYCController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_HaierHYC
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_HaierHYC()
        {
            List<BSLDNAExt_HaierHYC> Items = await _context.BSLDNAExt_HaierHYC.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_HaierHYC> payload)
        {
            BSLDNAExt_HaierHYC bSLDNAExt_HaierHYC = payload.value;
            _context.BSLDNAExt_HaierHYC.Add(bSLDNAExt_HaierHYC);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HaierHYC);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_HaierHYC> payload)
        {
            BSLDNAExt_HaierHYC bSLDNAExt_HaierHYC = payload.value;
            _context.BSLDNAExt_HaierHYC.Update(bSLDNAExt_HaierHYC);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HaierHYC);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_HaierHYC> payload)
        {
            BSLDNAExt_HaierHYC bSLDNAExt_HaierHYC = _context.BSLDNAExt_HaierHYC
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_HaierHYC.Remove(bSLDNAExt_HaierHYC);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HaierHYC);

        }
    }
}