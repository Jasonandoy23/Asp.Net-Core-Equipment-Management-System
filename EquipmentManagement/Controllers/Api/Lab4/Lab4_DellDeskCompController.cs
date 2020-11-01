using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using EquipmentManagement.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace EquipmentManagement.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Lab4_DellDeskComp")]
    public class Lab4_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab4_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab4_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetLab4_DellDeskComp()
        {
            List<Lab4_DellDeskComp> Items = await _context.Lab4_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab4_DellDeskComp> payload)
        {
            Lab4_DellDeskComp lab4_DellDeskComp = payload.value;
            _context.Lab4_DellDeskComp.Add(lab4_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab4_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab4_DellDeskComp> payload)
        {
            Lab4_DellDeskComp lab4_DellDeskComp = payload.value;
            _context.Lab4_DellDeskComp.Update(lab4_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab4_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab4_DellDeskComp> payload)
        {
            Lab4_DellDeskComp lab4_DellDeskComp = _context.Lab4_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab4_DellDeskComp.Remove(lab4_DellDeskComp);
            _context.SaveChanges();
            return Ok(lab4_DellDeskComp);

        }
    }
}