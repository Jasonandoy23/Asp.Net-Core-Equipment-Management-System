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
    [Route("api/Lab1_Others")]
    public class Lab1_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab1_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab1_Others
        [HttpGet]
        public async Task<IActionResult> GetLab1_Others()
        {
            List<Lab1_Others> Items = await _context.Lab1_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab1_Others> payload)
        {
            Lab1_Others lab1_Others = payload.value;
            _context.Lab1_Others.Add(lab1_Others);
            _context.SaveChanges();
            return Ok(lab1_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab1_Others> payload)
        {
            Lab1_Others lab1_Others = payload.value;
            _context.Lab1_Others.Update(lab1_Others);
            _context.SaveChanges();
            return Ok(lab1_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab1_Others> payload)
        {
            Lab1_Others lab1_Others = _context.Lab1_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab1_Others.Remove(lab1_Others);
            _context.SaveChanges();
            return Ok(lab1_Others);

        }
    }
}