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
    [Route("api/BSLDNAExt_DellDeskComp")]
    public class BSLDNAExt_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_DellDeskComp()
        {
            List<BSLDNAExt_DellDeskComp> Items = await _context.BSLDNAExt_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_DellDeskComp> payload)
        {
            BSLDNAExt_DellDeskComp bSLDNAExt_DellDeskComp = payload.value;
            _context.BSLDNAExt_DellDeskComp.Add(bSLDNAExt_DellDeskComp);
            _context.SaveChanges();
            return Ok(bSLDNAExt_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_DellDeskComp> payload)
        {
            BSLDNAExt_DellDeskComp bSLDNAExt_DellDeskComp = payload.value;
            _context.BSLDNAExt_DellDeskComp.Update(bSLDNAExt_DellDeskComp);
            _context.SaveChanges();
            return Ok(bSLDNAExt_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_DellDeskComp> payload)
        {
            BSLDNAExt_DellDeskComp bSLDNAExt_DellDeskComp = _context.BSLDNAExt_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_DellDeskComp.Remove(bSLDNAExt_DellDeskComp);
            _context.SaveChanges();
            return Ok(bSLDNAExt_DellDeskComp);

        }
    }
}