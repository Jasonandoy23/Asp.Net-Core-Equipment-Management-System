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
    [Route("api/Sections")]
    public class SectionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Sections
        [HttpGet]
        public async Task<IActionResult> GetSections()
        {
            List<Sections> Items = await _context.Sections.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Sections> payload)
        {
            Sections sections = payload.value;
            _context.Sections.Add(sections);
            _context.SaveChanges();
            return Ok(sections);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Sections> payload)
        {
            Sections sections = payload.value;
            _context.Sections.Update(sections);
            _context.SaveChanges();
            return Ok(sections);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Sections> payload)
        {
            Sections sections = _context.Sections
                .Where(x => x.Sections_id == (long)payload.key)
                .FirstOrDefault();
            _context.Sections.Remove(sections);
            _context.SaveChanges();
            return Ok(sections);

        }
    }
}