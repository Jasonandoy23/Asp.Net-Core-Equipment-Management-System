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
    [Route("api/RDLab_DellDeskComp")]
    public class RDLab_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetRDLab_DellDeskComp()
        {
            List<RDLab_DellDeskComp> Items = await _context.RDLab_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_DellDeskComp> payload)
        {
            RDLab_DellDeskComp rDLab_DellDeskComp = payload.value;
            _context.RDLab_DellDeskComp.Add(rDLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(rDLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_DellDeskComp> payload)
        {
            RDLab_DellDeskComp rDLab_DellDeskComp = payload.value;
            _context.RDLab_DellDeskComp.Update(rDLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(rDLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_DellDeskComp> payload)
        {
            RDLab_DellDeskComp rDLab_DellDeskComp = _context.RDLab_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_DellDeskComp.Remove(rDLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(rDLab_DellDeskComp);

        }
    }
}