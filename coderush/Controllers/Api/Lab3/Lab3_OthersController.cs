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
    [Route("api/Lab3_Others")]
    public class Lab3_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab3_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab3_Others
        [HttpGet]
        public async Task<IActionResult> GetLab3_Others()
        {
            List<Lab3_Others> Items = await _context.Lab3_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab3_Others> payload)
        {
            Lab3_Others lab3_Others = payload.value;
            _context.Lab3_Others.Add(lab3_Others);
            _context.SaveChanges();
            return Ok(lab3_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab3_Others> payload)
        {
            Lab3_Others lab3_Others = payload.value;
            _context.Lab3_Others.Update(lab3_Others);
            _context.SaveChanges();
            return Ok(lab3_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab3_Others> payload)
        {
            Lab3_Others lab3_Others = _context.Lab3_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab3_Others.Remove(lab3_Others);
            _context.SaveChanges();
            return Ok(lab3_Others);

        }
    }
}