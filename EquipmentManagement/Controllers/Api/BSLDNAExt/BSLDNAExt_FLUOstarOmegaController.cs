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
    [Route("api/BSLDNAExt_FLUOstarOmega")]
    public class BSLDNAExt_FLUOstarOmegaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_FLUOstarOmegaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_FLUOstarOmega
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_FLUOstarOmega()
        {
            List<BSLDNAExt_FLUOstarOmega> Items = await _context.BSLDNAExt_FLUOstarOmega.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_FLUOstarOmega> payload)
        {
            BSLDNAExt_FLUOstarOmega bSLDNAExt_FLUOstarOmega = payload.value;
            _context.BSLDNAExt_FLUOstarOmega.Add(bSLDNAExt_FLUOstarOmega);
            _context.SaveChanges();
            return Ok(bSLDNAExt_FLUOstarOmega);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_FLUOstarOmega> payload)
        {
            BSLDNAExt_FLUOstarOmega bSLDNAExt_FLUOstarOmega = payload.value;
            _context.BSLDNAExt_FLUOstarOmega.Update(bSLDNAExt_FLUOstarOmega);
            _context.SaveChanges();
            return Ok(bSLDNAExt_FLUOstarOmega);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_FLUOstarOmega> payload)
        {
            BSLDNAExt_FLUOstarOmega bSLDNAExt_FLUOstarOmega = _context.BSLDNAExt_FLUOstarOmega
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_FLUOstarOmega.Remove(bSLDNAExt_FLUOstarOmega);
            _context.SaveChanges();
            return Ok(bSLDNAExt_FLUOstarOmega);

        }
    }
}