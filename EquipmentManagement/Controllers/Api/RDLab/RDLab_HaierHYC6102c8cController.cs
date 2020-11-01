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
    [Route("api/RDLab_HaierHYC6102c8c")]
    public class RDLab_HaierHYC6102c8cController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_HaierHYC6102c8cController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_HaierHYC6102c8c
        [HttpGet]
        public async Task<IActionResult> GetRDLab_HaierHYC6102c8c()
        {
            List<RDLab_HaierHYC6102c8c> Items = await _context.RDLab_HaierHYC6102c8c.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_HaierHYC6102c8c> payload)
        {
            RDLab_HaierHYC6102c8c rDLab_HaierHYC6102c8c = payload.value;
            _context.RDLab_HaierHYC6102c8c.Add(rDLab_HaierHYC6102c8c);
            _context.SaveChanges();
            return Ok(rDLab_HaierHYC6102c8c);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_HaierHYC6102c8c> payload)
        {
            RDLab_HaierHYC6102c8c rDLab_HaierHYC6102c8c = payload.value;
            _context.RDLab_HaierHYC6102c8c.Update(rDLab_HaierHYC6102c8c);
            _context.SaveChanges();
            return Ok(rDLab_HaierHYC6102c8c);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_HaierHYC6102c8c> payload)
        {
            RDLab_HaierHYC6102c8c rDLab_HaierHYC6102c8c = _context.RDLab_HaierHYC6102c8c
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_HaierHYC6102c8c.Remove(rDLab_HaierHYC6102c8c);
            _context.SaveChanges();
            return Ok(rDLab_HaierHYC6102c8c);

        }
    }
}