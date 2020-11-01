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
    [Route("api/ONTSeqLab_PromethIONSeqUnit")]
    public class ONTSeqLab_PromethIONSeqUnitController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_PromethIONSeqUnitController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_PromethIONSeqUnit
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_PromethIONSeqUnit()
        {
            List<ONTSeqLab_PromethIONSeqUnit> Items = await _context.ONTSeqLab_PromethIONSeqUnit.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_PromethIONSeqUnit> payload)
        {
            ONTSeqLab_PromethIONSeqUnit oNTSeqLab_PromethIONSeqUnit = payload.value;
            _context.ONTSeqLab_PromethIONSeqUnit.Add(oNTSeqLab_PromethIONSeqUnit);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PromethIONSeqUnit);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_PromethIONSeqUnit> payload)
        {
            ONTSeqLab_PromethIONSeqUnit oNTSeqLab_PromethIONSeqUnit = payload.value;
            _context.ONTSeqLab_PromethIONSeqUnit.Update(oNTSeqLab_PromethIONSeqUnit);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PromethIONSeqUnit);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_PromethIONSeqUnit> payload)
        {
            ONTSeqLab_PromethIONSeqUnit oNTSeqLab_PromethIONSeqUnit = _context.ONTSeqLab_PromethIONSeqUnit
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_PromethIONSeqUnit.Remove(oNTSeqLab_PromethIONSeqUnit);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PromethIONSeqUnit);

        }
    }
}