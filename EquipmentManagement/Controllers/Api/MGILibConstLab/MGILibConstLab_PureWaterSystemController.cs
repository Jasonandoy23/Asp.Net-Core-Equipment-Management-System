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
    [Route("api/MGILibConstLab_PureWaterSystem")]
    public class MGILibConstLab_PureWaterSystemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_PureWaterSystemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_PureWaterSystem
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_PureWaterSystem()
        {
            List<MGILibConstLab_PureWaterSystem> Items = await _context.MGILibConstLab_PureWaterSystem.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_PureWaterSystem> payload)
        {
            MGILibConstLab_PureWaterSystem mGILibConstLab_PureWaterSystem = payload.value;
            _context.MGILibConstLab_PureWaterSystem.Add(mGILibConstLab_PureWaterSystem);
            _context.SaveChanges();
            return Ok(mGILibConstLab_PureWaterSystem);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_PureWaterSystem> payload)
        {
            MGILibConstLab_PureWaterSystem mGILibConstLab_PureWaterSystem = payload.value;
            _context.MGILibConstLab_PureWaterSystem.Update(mGILibConstLab_PureWaterSystem);
            _context.SaveChanges();
            return Ok(mGILibConstLab_PureWaterSystem);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_PureWaterSystem> payload)
        {
            MGILibConstLab_PureWaterSystem mGILibConstLab_PureWaterSystem = _context.MGILibConstLab_PureWaterSystem
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_PureWaterSystem.Remove(mGILibConstLab_PureWaterSystem);
            _context.SaveChanges();
            return Ok(mGILibConstLab_PureWaterSystem);

        }
    }
}