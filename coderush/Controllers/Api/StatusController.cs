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
    [Route("api/Status")]
    public class StatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Status
        [HttpGet]
        public async Task<IActionResult> GetStatus()
        {
            List<Status> Items = await _context.Status.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Status> payload)
        {
            Status status = payload.value;
            _context.Status.Add(status);
            _context.SaveChanges();
            return Ok(status);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Status> payload)
        {
            Status status = payload.value;
            _context.Status.Update(status);
            _context.SaveChanges();
            return Ok(status);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Status> payload)
        {
            Status status = _context.Status
                .Where(x => x.Status_id == (long)payload.key)
                .FirstOrDefault();
            _context.Status.Remove(status);
            _context.SaveChanges();
            return Ok(status);

        }
    }
}
