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
    [Route("api/CP1_ThermoFisher80")]
    public class CP1_ThermoFisher80Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public CP1_ThermoFisher80Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CP1_ThermoFisher80
        [HttpGet]
        public async Task<IActionResult> GetCP1_ThermoFisher80()
        {
            List<CP1_ThermoFisher80> Items = await _context.CP1_ThermoFisher80.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<CP1_ThermoFisher80> payload)
        {
            CP1_ThermoFisher80 cP1_ThermoFisher80 = payload.value;
            _context.CP1_ThermoFisher80.Add(cP1_ThermoFisher80);
            _context.SaveChanges();
            return Ok(cP1_ThermoFisher80);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<CP1_ThermoFisher80> payload)
        {
            CP1_ThermoFisher80 cP1_ThermoFisher80 = payload.value;
            _context.CP1_ThermoFisher80.Update(cP1_ThermoFisher80);
            _context.SaveChanges();
            return Ok(cP1_ThermoFisher80);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<CP1_ThermoFisher80> payload)
        {
            CP1_ThermoFisher80 cP1_ThermoFisher80 = _context.CP1_ThermoFisher80
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.CP1_ThermoFisher80.Remove(cP1_ThermoFisher80);
            _context.SaveChanges();
            return Ok(cP1_ThermoFisher80);

        }
    }
}