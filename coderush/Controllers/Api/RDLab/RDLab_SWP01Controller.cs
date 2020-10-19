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
    [Route("api/RDLab_SWP01")]
    public class RDLab_SWP01Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_SWP01Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_SWP01
        [HttpGet]
        public async Task<IActionResult> GetRDLab_SWP01()
        {
            List<RDLab_SWP01> Items = await _context.RDLab_SWP01.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_SWP01> payload)
        {
            RDLab_SWP01 rDLab_SWP01 = payload.value;
            _context.RDLab_SWP01.Add(rDLab_SWP01);
            _context.SaveChanges();
            return Ok(rDLab_SWP01);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_SWP01> payload)
        {
            RDLab_SWP01 rDLab_SWP01 = payload.value;
            _context.RDLab_SWP01.Update(rDLab_SWP01);
            _context.SaveChanges();
            return Ok(rDLab_SWP01);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_SWP01> payload)
        {
            RDLab_SWP01 rDLab_SWP01 = _context.RDLab_SWP01
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_SWP01.Remove(rDLab_SWP01);
            _context.SaveChanges();
            return Ok(rDLab_SWP01);

        }
    }
}