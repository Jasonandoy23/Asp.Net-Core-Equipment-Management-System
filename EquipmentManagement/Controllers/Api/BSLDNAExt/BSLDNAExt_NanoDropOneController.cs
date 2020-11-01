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
    [Route("api/BSLDNAExt_NanoDropOne")]
    public class BSLDNAExt_NanoDropOneController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_NanoDropOneController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_NanoDropOne
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_NanoDropOne()
        {
            List<BSLDNAExt_NanoDropOne> Items = await _context.BSLDNAExt_NanoDropOne.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_NanoDropOne> payload)
        {
            BSLDNAExt_NanoDropOne bSLDNAExt_NanoDropOne = payload.value;
            _context.BSLDNAExt_NanoDropOne.Add(bSLDNAExt_NanoDropOne);
            _context.SaveChanges();
            return Ok(bSLDNAExt_NanoDropOne);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_NanoDropOne> payload)
        {
            BSLDNAExt_NanoDropOne bSLDNAExt_NanoDropOne = payload.value;
            _context.BSLDNAExt_NanoDropOne.Update(bSLDNAExt_NanoDropOne);
            _context.SaveChanges();
            return Ok(bSLDNAExt_NanoDropOne);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_NanoDropOne> payload)
        {
            BSLDNAExt_NanoDropOne bSLDNAExt_NanoDropOne = _context.BSLDNAExt_NanoDropOne
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_NanoDropOne.Remove(bSLDNAExt_NanoDropOne);
            _context.SaveChanges();
            return Ok(bSLDNAExt_NanoDropOne);

        }
    }
}