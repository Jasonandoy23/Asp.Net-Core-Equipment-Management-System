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
    [Route("api/Instruments")]
    public class InstrumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstrumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/instruments
        [HttpGet]
        public async Task<IActionResult> GetInstruments()
        {
            List<Instruments> Items = await _context.Instruments.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Instruments> payload)
        {
            Instruments instruments = payload.value;
            _context.Instruments.Add(instruments);
            _context.SaveChanges();
            return Ok(instruments);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Instruments> payload)
        {
            Instruments instruments = payload.value;
            _context.Instruments.Update(instruments);
            _context.SaveChanges();
            return Ok(instruments);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Instruments> payload)
        {
            Instruments instruments = _context.Instruments
                .Where(x => x.Instru_id == (long)payload.key)
                .FirstOrDefault();
            _context.Instruments.Remove(instruments);
            _context.SaveChanges();
            return Ok(instruments);

        }
    }
}
