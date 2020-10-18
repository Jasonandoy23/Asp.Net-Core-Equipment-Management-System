using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coderush.Data;
using coderush.Models;
using coderush.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace coderush.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/BSLDNAExt_HaierDW_40L508DeepFreezer")]
    public class BSLDNAExt_HaierDW_40L508DeepFreezerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLDNAExt_HaierDW_40L508DeepFreezerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLDNAExt_HaierDW_40L508DeepFreezer
        [HttpGet]
        public async Task<IActionResult> GetBSLDNAExt_HaierDW_40L508DeepFreezer()
        {
            List<BSLDNAExt_HaierDW_40L508DeepFreezer> Items = await _context.BSLDNAExt_HaierDW_40L508DeepFreezer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLDNAExt_HaierDW_40L508DeepFreezer> payload)
        {
            BSLDNAExt_HaierDW_40L508DeepFreezer bSLDNAExt_HaierDW_40L508DeepFreezer = payload.value;
            _context.BSLDNAExt_HaierDW_40L508DeepFreezer.Add(bSLDNAExt_HaierDW_40L508DeepFreezer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HaierDW_40L508DeepFreezer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLDNAExt_HaierDW_40L508DeepFreezer> payload)
        {
            BSLDNAExt_HaierDW_40L508DeepFreezer bSLDNAExt_HaierDW_40L508DeepFreezer = payload.value;
            _context.BSLDNAExt_HaierDW_40L508DeepFreezer.Update(bSLDNAExt_HaierDW_40L508DeepFreezer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HaierDW_40L508DeepFreezer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLDNAExt_HaierDW_40L508DeepFreezer> payload)
        {
            BSLDNAExt_HaierDW_40L508DeepFreezer bSLDNAExt_HaierDW_40L508DeepFreezer = _context.BSLDNAExt_HaierDW_40L508DeepFreezer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLDNAExt_HaierDW_40L508DeepFreezer.Remove(bSLDNAExt_HaierDW_40L508DeepFreezer);
            _context.SaveChanges();
            return Ok(bSLDNAExt_HaierDW_40L508DeepFreezer);

        }
    }
}