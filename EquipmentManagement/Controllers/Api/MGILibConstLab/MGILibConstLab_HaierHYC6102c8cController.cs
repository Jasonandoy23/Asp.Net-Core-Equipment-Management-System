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
    [Route("api/MGILibConstLab_HaierHYC6102c8c")]
    public class MGILibConstLab_HaierHYC6102c8cController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_HaierHYC6102c8cController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_HaierHYC6102c8c
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_HaierHYC6102c8c()
        {
            List<MGILibConstLab_HaierHYC6102c8c> Items = await _context.MGILibConstLab_HaierHYC6102c8c.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_HaierHYC6102c8c> payload)
        {
            MGILibConstLab_HaierHYC6102c8c mGILibConstLab_HaierHYC6102c8c = payload.value;
            _context.MGILibConstLab_HaierHYC6102c8c.Add(mGILibConstLab_HaierHYC6102c8c);
            _context.SaveChanges();
            return Ok(mGILibConstLab_HaierHYC6102c8c);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_HaierHYC6102c8c> payload)
        {
            MGILibConstLab_HaierHYC6102c8c mGILibConstLab_HaierHYC6102c8c = payload.value;
            _context.MGILibConstLab_HaierHYC6102c8c.Update(mGILibConstLab_HaierHYC6102c8c);
            _context.SaveChanges();
            return Ok(mGILibConstLab_HaierHYC6102c8c);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_HaierHYC6102c8c> payload)
        {
            MGILibConstLab_HaierHYC6102c8c mGILibConstLab_HaierHYC6102c8c = _context.MGILibConstLab_HaierHYC6102c8c
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_HaierHYC6102c8c.Remove(mGILibConstLab_HaierHYC6102c8c);
            _context.SaveChanges();
            return Ok(mGILibConstLab_HaierHYC6102c8c);

        }
    }
}