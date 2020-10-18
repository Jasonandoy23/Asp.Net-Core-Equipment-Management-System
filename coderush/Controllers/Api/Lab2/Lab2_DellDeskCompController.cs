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
    [Route("api/Lab2_DellDeskComp")]
    public class Lab2_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab2_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab2_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetLab2_DellDeskComp()
        {
            List<Lab2_DellDeskComp> Items = await _context.Lab2_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab2_DellDeskComp> payload)
        {
            Lab2_DellDeskComp lab2_DellDeskComp = payload.value;
            _context.Lab2_DellDeskComp.Add(lab2_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab2_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab2_DellDeskComp> payload)
        {
            Lab2_DellDeskComp lab2_DellDeskComp = payload.value;
            _context.Lab2_DellDeskComp.Update(lab2_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab2_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab2_DellDeskComp> payload)
        {
            Lab2_DellDeskComp lab2_DellDeskComp = _context.Lab2_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab2_DellDeskComp.Remove(lab2_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab2_DellDeskComp);

        }
    }
}