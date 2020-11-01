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
    [Route("api/RDLab_ThermalCycler")]
    public class RDLab_ThermalCyclerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_ThermalCyclerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_ThermalCycler
        [HttpGet]
        public async Task<IActionResult> GetRDLab_ThermalCycler()
        {
            List<RDLab_ThermalCycler> Items = await _context.RDLab_ThermalCycler.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_ThermalCycler> payload)
        {
            RDLab_ThermalCycler rDLab_ThermalCycler = payload.value;
            _context.RDLab_ThermalCycler.Add(rDLab_ThermalCycler);
            _context.SaveChanges();
            return Ok(rDLab_ThermalCycler);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_ThermalCycler> payload)
        {
            RDLab_ThermalCycler rDLab_ThermalCycler = payload.value;
            _context.RDLab_ThermalCycler.Update(rDLab_ThermalCycler);
            _context.SaveChanges();
            return Ok(rDLab_ThermalCycler);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_ThermalCycler> payload)
        {
            RDLab_ThermalCycler rDLab_ThermalCycler = _context.RDLab_ThermalCycler
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_ThermalCycler.Remove(rDLab_ThermalCycler);
            _context.SaveChanges();
            return Ok(rDLab_ThermalCycler);

        }
    }
}