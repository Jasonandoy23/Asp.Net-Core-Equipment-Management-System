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
    [Route("api/MGILibConstLab_ThermalCycler")]
    public class MGILibConstLab_ThermalCyclerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_ThermalCyclerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_ThermalCycler
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_ThermalCycler()
        {
            List<MGILibConstLab_ThermalCycler> Items = await _context.MGILibConstLab_ThermalCycler.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_ThermalCycler> payload)
        {
            MGILibConstLab_ThermalCycler mGILibConstLab_ThermalCycler = payload.value;
            _context.MGILibConstLab_ThermalCycler.Add(mGILibConstLab_ThermalCycler);
            _context.SaveChanges();
            return Ok(mGILibConstLab_ThermalCycler);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_ThermalCycler> payload)
        {
            MGILibConstLab_ThermalCycler mGILibConstLab_ThermalCycler = payload.value;
            _context.MGILibConstLab_ThermalCycler.Update(mGILibConstLab_ThermalCycler);
            _context.SaveChanges();
            return Ok(mGILibConstLab_ThermalCycler);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_ThermalCycler> payload)
        {
            MGILibConstLab_ThermalCycler mGILibConstLab_ThermalCycler = _context.MGILibConstLab_ThermalCycler
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_ThermalCycler.Remove(mGILibConstLab_ThermalCycler);
            _context.SaveChanges();
            return Ok(mGILibConstLab_ThermalCycler);

        }
    }
}