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
    [Route("api/BSLDNAExt_MicroLabNIMBUS4")]
    public class BSLDNAExt_MicroLabNIMBUS4Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_MicroLabNIMBUS4Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_MicroLabNIMBUS4
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_MicroLabNIMBUS4()
        {
            List<BSLDNAExt_MicroLabNIMBUS4> Items = await _context.BSLDNAExt_MicroLabNIMBUS4.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_MicroLabNIMBUS4> payload)
        {
            BSLDNAExt_MicroLabNIMBUS4 bSLDNAExt_MicroLabNIMBUS4 = payload.value;
            _context.BSLDNAExt_MicroLabNIMBUS4.Add(bSLDNAExt_MicroLabNIMBUS4);
            _context.SaveChanges();
            return Ok(bSLDNAExt_MicroLabNIMBUS4);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_MicroLabNIMBUS4> payload)
        {
            BSLDNAExt_MicroLabNIMBUS4 bSLDNAExt_MicroLabNIMBUS4 = payload.value;
            _context.BSLDNAExt_MicroLabNIMBUS4.Update(bSLDNAExt_MicroLabNIMBUS4);
            _context.SaveChanges();
            return Ok(bSLDNAExt_MicroLabNIMBUS4);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_MicroLabNIMBUS4> payload)
        {
            BSLDNAExt_MicroLabNIMBUS4 bSLDNAExt_MicroLabNIMBUS4 = _context.BSLDNAExt_MicroLabNIMBUS4
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_MicroLabNIMBUS4.Remove(bSLDNAExt_MicroLabNIMBUS4);
            _context.SaveChanges();
            return Ok(bSLDNAExt_MicroLabNIMBUS4);

        }
    }
}