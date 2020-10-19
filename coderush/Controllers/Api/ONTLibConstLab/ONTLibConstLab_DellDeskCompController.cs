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
    [Route("api/ONTLibConstLab_DellDeskComp")]
    public class ONTLibConstLab_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTLibConstLab_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTLibConstLab_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetONTLibConstLab_DellDeskComp()
        {
            List<ONTLibConstLab_DellDeskComp> Items = await _context.ONTLibConstLab_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTLibConstLab_DellDeskComp> payload)
        {
            ONTLibConstLab_DellDeskComp oNTLibConstLab_DellDeskComp = payload.value;
            _context.ONTLibConstLab_DellDeskComp.Add(oNTLibConstLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(oNTLibConstLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTLibConstLab_DellDeskComp> payload)
        {
            ONTLibConstLab_DellDeskComp oNTLibConstLab_DellDeskComp = payload.value;
            _context.ONTLibConstLab_DellDeskComp.Update(oNTLibConstLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(oNTLibConstLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTLibConstLab_DellDeskComp> payload)
        {
            ONTLibConstLab_DellDeskComp oNTLibConstLab_DellDeskComp = _context.ONTLibConstLab_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTLibConstLab_DellDeskComp.Remove(oNTLibConstLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(oNTLibConstLab_DellDeskComp);

        }
    }
}