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
    [Route("api/RDLab_FastPrep966010500")]
    public class RDLab_FastPrep966010500Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_FastPrep966010500Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_FastPrep966010500
        [HttpGet]
        public async Task<IActionResult> GetRDLab_FastPrep966010500()
        {
            List<RDLab_FastPrep966010500> Items = await _context.RDLab_FastPrep966010500.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_FastPrep966010500> payload)
        {
            RDLab_FastPrep966010500 rDLab_FastPrep966010500 = payload.value;
            _context.RDLab_FastPrep966010500.Add(rDLab_FastPrep966010500);
            _context.SaveChanges();
            return Ok(rDLab_FastPrep966010500);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_FastPrep966010500> payload)
        {
            RDLab_FastPrep966010500 rDLab_FastPrep966010500 = payload.value;
            _context.RDLab_FastPrep966010500.Update(rDLab_FastPrep966010500);
            _context.SaveChanges();
            return Ok(rDLab_FastPrep966010500);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_FastPrep966010500> payload)
        {
            RDLab_FastPrep966010500 rDLab_FastPrep966010500 = _context.RDLab_FastPrep966010500
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_FastPrep966010500.Remove(rDLab_FastPrep966010500);
            _context.SaveChanges();
            return Ok(rDLab_FastPrep966010500);

        }
    }
}