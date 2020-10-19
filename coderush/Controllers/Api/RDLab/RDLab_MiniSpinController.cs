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
    [Route("api/RDLab_MiniSpin")]
    public class RDLab_MiniSpinController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_MiniSpinController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_MiniSpin
        [HttpGet]
        public async Task<IActionResult> GetRDLab_MiniSpin()
        {
            List<RDLab_MiniSpin> Items = await _context.RDLab_MiniSpin.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_MiniSpin> payload)
        {
            RDLab_MiniSpin rDLab_MiniSpin = payload.value;
            _context.RDLab_MiniSpin.Add(rDLab_MiniSpin);
            _context.SaveChanges();
            return Ok(rDLab_MiniSpin);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_MiniSpin> payload)
        {
            RDLab_MiniSpin rDLab_MiniSpin = payload.value;
            _context.RDLab_MiniSpin.Update(rDLab_MiniSpin);
            _context.SaveChanges();
            return Ok(rDLab_MiniSpin);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_MiniSpin> payload)
        {
            RDLab_MiniSpin rDLab_MiniSpin = _context.RDLab_MiniSpin
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_MiniSpin.Remove(rDLab_MiniSpin);
            _context.SaveChanges();
            return Ok(rDLab_MiniSpin);

        }
    }
}