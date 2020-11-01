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
    [Route("api/MGISeqLab_T10BiochemicalPlatformPart")]
    public class MGISeqLab_T10BiochemicalPlatformPartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_T10BiochemicalPlatformPartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_T10BiochemicalPlatformPart
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_T10BiochemicalPlatformPart()
        {
            List<MGISeqLab_T10BiochemicalPlatformPart> Items = await _context.MGISeqLab_T10BiochemicalPlatformPart.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_T10BiochemicalPlatformPart> payload)
        {
            MGISeqLab_T10BiochemicalPlatformPart mGISeqLab_T10BiochemicalPlatformPart = payload.value;
            _context.MGISeqLab_T10BiochemicalPlatformPart.Add(mGISeqLab_T10BiochemicalPlatformPart);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10BiochemicalPlatformPart);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_T10BiochemicalPlatformPart> payload)
        {
            MGISeqLab_T10BiochemicalPlatformPart mGISeqLab_T10BiochemicalPlatformPart = payload.value;
            _context.MGISeqLab_T10BiochemicalPlatformPart.Update(mGISeqLab_T10BiochemicalPlatformPart);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10BiochemicalPlatformPart);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_T10BiochemicalPlatformPart> payload)
        {
            MGISeqLab_T10BiochemicalPlatformPart mGISeqLab_T10BiochemicalPlatformPart = _context.MGISeqLab_T10BiochemicalPlatformPart
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_T10BiochemicalPlatformPart.Remove(mGISeqLab_T10BiochemicalPlatformPart);
            _context.SaveChanges();
            return Ok(mGISeqLab_T10BiochemicalPlatformPart);

        }
    }
}