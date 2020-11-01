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
    [Route("api/RDLab_PowerPacBasic")]
    public class RDLab_PowerPacBasicController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_PowerPacBasicController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_PowerPacBasic
        [HttpGet]
        public async Task<IActionResult> GetRDLab_PowerPacBasic()
        {
            List<RDLab_PowerPacBasic> Items = await _context.RDLab_PowerPacBasic.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_PowerPacBasic> payload)
        {
            RDLab_PowerPacBasic rDLab_PowerPacBasic = payload.value;
            _context.RDLab_PowerPacBasic.Add(rDLab_PowerPacBasic);
            _context.SaveChanges();
            return Ok(rDLab_PowerPacBasic);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_PowerPacBasic> payload)
        {
            RDLab_PowerPacBasic rDLab_PowerPacBasic = payload.value;
            _context.RDLab_PowerPacBasic.Update(rDLab_PowerPacBasic);
            _context.SaveChanges();
            return Ok(rDLab_PowerPacBasic);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_PowerPacBasic> payload)
        {
            RDLab_PowerPacBasic rDLab_PowerPacBasic = _context.RDLab_PowerPacBasic
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_PowerPacBasic.Remove(rDLab_PowerPacBasic);
            _context.SaveChanges();
            return Ok(rDLab_PowerPacBasic);

        }
    }
}