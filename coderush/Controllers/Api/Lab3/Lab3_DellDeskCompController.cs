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
    [Route("api/Lab3_DellDeskComp")]
    public class Lab3_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab3_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab3_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetLab3_DellDeskComp()
        {
            List<Lab3_DellDeskComp> Items = await _context.Lab3_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab3_DellDeskComp> payload)
        {
            Lab3_DellDeskComp lab3_DellDeskComp = payload.value;
            _context.Lab3_DellDeskComp.Add(lab3_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab3_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab3_DellDeskComp> payload)
        {
            Lab3_DellDeskComp lab3_DellDeskComp = payload.value;
            _context.Lab3_DellDeskComp.Update(lab3_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab3_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab3_DellDeskComp> payload)
        {
            Lab3_DellDeskComp lab3_DellDeskComp = _context.Lab3_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab3_DellDeskComp.Remove(lab3_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab3_DellDeskComp);

        }
    }
}