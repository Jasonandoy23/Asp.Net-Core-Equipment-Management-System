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
    [Route("api/MGISeqLab_Ztron")]
    public class MGISeqLab_ZtronController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGISeqLab_ZtronController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGISeqLab_Ztron
        [HttpGet]
        public async Task<IActionResult> GetMGISeqLab_Ztron()
        {
            List<MGISeqLab_Ztron> Items = await _context.MGISeqLab_Ztron.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGISeqLab_Ztron> payload)
        {
            MGISeqLab_Ztron mGISeqLab_Ztron = payload.value;
            _context.MGISeqLab_Ztron.Add(mGISeqLab_Ztron);
            _context.SaveChanges();
            return Ok(mGISeqLab_Ztron);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGISeqLab_Ztron> payload)
        {
            MGISeqLab_Ztron mGISeqLab_Ztron = payload.value;
            _context.MGISeqLab_Ztron.Update(mGISeqLab_Ztron);
            _context.SaveChanges();
            return Ok(mGISeqLab_Ztron);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGISeqLab_Ztron> payload)
        {
            MGISeqLab_Ztron mGISeqLab_Ztron = _context.MGISeqLab_Ztron
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGISeqLab_Ztron.Remove(mGISeqLab_Ztron);
            _context.SaveChanges();
            return Ok(mGISeqLab_Ztron);

        }
    }
}