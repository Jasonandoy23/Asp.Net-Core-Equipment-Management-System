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
    [Route("api/CP1_DellDeskComp")]
    public class CP1_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CP1_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CP1_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetCP1_DellDeskComp()
        {
            List<CP1_DellDeskComp> Items = await _context.CP1_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<CP1_DellDeskComp> payload)
        {
            CP1_DellDeskComp cP1_DellDeskComp = payload.value;
            _context.CP1_DellDeskComp.Add(cP1_DellDeskComp);
            _context.SaveChanges();
            return Ok(cP1_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<CP1_DellDeskComp> payload)
        {
            CP1_DellDeskComp cP1_DellDeskComp = payload.value;
            _context.CP1_DellDeskComp.Update(cP1_DellDeskComp);
            _context.SaveChanges();
            return Ok(cP1_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<CP1_DellDeskComp> payload)
        {
            CP1_DellDeskComp cP1_DellDeskComp = _context.CP1_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.CP1_DellDeskComp.Remove(cP1_DellDeskComp);
            _context.SaveChanges();
            return Ok(cP1_DellDeskComp);

        }
    }
}