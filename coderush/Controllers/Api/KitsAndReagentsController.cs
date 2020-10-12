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
    [Route("api/KitsAndReagents")]
    public class KitsAndReagentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KitsAndReagentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/KitsAndReagents
        [HttpGet]
        public async Task<IActionResult> GetKitsAndReagents()
        {
            List<KitsAndReagents> Items = await _context.KitsAndReagents.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<KitsAndReagents> payload)
        {
            KitsAndReagents kitsAndReagents = payload.value;
            _context.KitsAndReagents.Add(kitsAndReagents);
            _context.SaveChanges();
            return Ok(kitsAndReagents);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<KitsAndReagents> payload)
        {
            KitsAndReagents kitsAndReagents = payload.value;
            _context.KitsAndReagents.Update(kitsAndReagents);
            _context.SaveChanges();
            return Ok(kitsAndReagents);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<KitsAndReagents> payload)
        {
            KitsAndReagents kitsAndReagents = _context.KitsAndReagents
                .Where(x => x.KR_id == (long)payload.key)
                .FirstOrDefault();
            _context.KitsAndReagents.Remove(kitsAndReagents);
            _context.SaveChanges();
            return Ok(kitsAndReagents);

        }
    }
}