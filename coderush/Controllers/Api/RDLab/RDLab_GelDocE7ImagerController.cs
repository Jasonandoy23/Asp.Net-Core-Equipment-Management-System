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
    [Route("api/RDLab_GelDocE7Imager")]
    public class RDLab_GelDocE7ImagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_GelDocE7ImagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_GelDocE7Imager
        [HttpGet]
        public async Task<IActionResult> GetRDLab_GelDocE7Imager()
        {
            List<RDLab_GelDocE7Imager> Items = await _context.RDLab_GelDocE7Imager.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_GelDocE7Imager> payload)
        {
            RDLab_GelDocE7Imager rDLab_GelDocE7Imager = payload.value;
            _context.RDLab_GelDocE7Imager.Add(rDLab_GelDocE7Imager);
            _context.SaveChanges();
            return Ok(rDLab_GelDocE7Imager);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_GelDocE7Imager> payload)
        {
            RDLab_GelDocE7Imager rDLab_GelDocE7Imager = payload.value;
            _context.RDLab_GelDocE7Imager.Update(rDLab_GelDocE7Imager);
            _context.SaveChanges();
            return Ok(rDLab_GelDocE7Imager);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_GelDocE7Imager> payload)
        {
            RDLab_GelDocE7Imager rDLab_GelDocE7Imager = _context.RDLab_GelDocE7Imager
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_GelDocE7Imager.Remove(rDLab_GelDocE7Imager);
            _context.SaveChanges();
            return Ok(rDLab_GelDocE7Imager);

        }
    }
}