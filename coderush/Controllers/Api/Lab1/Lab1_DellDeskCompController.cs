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
    [Route("api/Lab1_DellDeskComp")]
    public class Lab1_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab1_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab1_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetLab1_DellDeskComp()
        {
            List<Lab1_DellDeskComp> Items = await _context.Lab1_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab1_DellDeskComp> payload)
        {
            Lab1_DellDeskComp lab1_DellDeskComp = payload.value;
            _context.Lab1_DellDeskComp.Add(lab1_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab1_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab1_DellDeskComp> payload)
        {
            Lab1_DellDeskComp lab1_DellDeskComp = payload.value;
            _context.Lab1_DellDeskComp.Update(lab1_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab1_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab1_DellDeskComp> payload)
        {
            Lab1_DellDeskComp lab1_DellDeskComp = _context.Lab1_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab1_DellDeskComp.Remove(lab1_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab1_DellDeskComp);

        }
    }
}