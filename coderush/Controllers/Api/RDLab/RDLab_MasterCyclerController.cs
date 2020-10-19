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
    [Route("api/RDLab_MasterCycler")]
    public class RDLab_MasterCyclerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_MasterCyclerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_MasterCycler
        [HttpGet]
        public async Task<IActionResult> GetRDLab_MasterCycler()
        {
            List<RDLab_MasterCycler> Items = await _context.RDLab_MasterCycler.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_MasterCycler> payload)
        {
            RDLab_MasterCycler rDLab_MasterCycler = payload.value;
            _context.RDLab_MasterCycler.Add(rDLab_MasterCycler);
            _context.SaveChanges();
            return Ok(rDLab_MasterCycler);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_MasterCycler> payload)
        {
            RDLab_MasterCycler rDLab_MasterCycler = payload.value;
            _context.RDLab_MasterCycler.Update(rDLab_MasterCycler);
            _context.SaveChanges();
            return Ok(rDLab_MasterCycler);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_MasterCycler> payload)
        {
            RDLab_MasterCycler rDLab_MasterCycler = _context.RDLab_MasterCycler
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_MasterCycler.Remove(rDLab_MasterCycler);
            _context.SaveChanges();
            return Ok(rDLab_MasterCycler);

        }
    }
}