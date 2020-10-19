using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coderush.Data;
using coderush.Models;
using coderush.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace coderush.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/RDLab_HeatStri")]
    public class RDLab_HeatStriController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_HeatStriController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_HeatStri
        [HttpGet]
        public async Task<IActionResult> GetRDLab_HeatStri()
        {
            List<RDLab_HeatStri> Items = await _context.RDLab_HeatStri.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_HeatStri> payload)
        {
            RDLab_HeatStri rDLab_HeatStri = payload.value;
            _context.RDLab_HeatStri.Add(rDLab_HeatStri);
            _context.SaveChanges();
            return Ok(rDLab_HeatStri);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_HeatStri> payload)
        {
            RDLab_HeatStri rDLab_HeatStri = payload.value;
            _context.RDLab_HeatStri.Update(rDLab_HeatStri);
            _context.SaveChanges();
            return Ok(rDLab_HeatStri);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_HeatStri> payload)
        {
            RDLab_HeatStri rDLab_HeatStri = _context.RDLab_HeatStri
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_HeatStri.Remove(rDLab_HeatStri);
            _context.SaveChanges();
            return Ok(rDLab_HeatStri);

        }
    }
}