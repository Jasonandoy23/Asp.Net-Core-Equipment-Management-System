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
    [Route("api/RDLab_MicrowaveOven")]
    public class RDLab_MicrowaveOvenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_MicrowaveOvenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_MicrowaveOven
        [HttpGet]
        public async Task<IActionResult> GetRDLab_MicrowaveOven()
        {
            List<RDLab_MicrowaveOven> Items = await _context.RDLab_MicrowaveOven.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_MicrowaveOven> payload)
        {
            RDLab_MicrowaveOven rDLab_MicrowaveOven = payload.value;
            _context.RDLab_MicrowaveOven.Add(rDLab_MicrowaveOven);
            _context.SaveChanges();
            return Ok(rDLab_MicrowaveOven);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_MicrowaveOven> payload)
        {
            RDLab_MicrowaveOven rDLab_MicrowaveOven = payload.value;
            _context.RDLab_MicrowaveOven.Update(rDLab_MicrowaveOven);
            _context.SaveChanges();
            return Ok(rDLab_MicrowaveOven);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_MicrowaveOven> payload)
        {
            RDLab_MicrowaveOven rDLab_MicrowaveOven = _context.RDLab_MicrowaveOven
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_MicrowaveOven.Remove(rDLab_MicrowaveOven);
            _context.SaveChanges();
            return Ok(rDLab_MicrowaveOven);

        }
    }
}