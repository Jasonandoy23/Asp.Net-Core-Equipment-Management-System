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
    [Route("api/RDLab_HaierDW40L508DeepFreezer40c20c")]
    public class RDLab_HaierDW40L508DeepFreezer40c20cController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_HaierDW40L508DeepFreezer40c20cController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_HaierDW40L508DeepFreezer40c20c
        [HttpGet]
        public async Task<IActionResult> GetRDLab_HaierDW40L508DeepFreezer40c20c()
        {
            List<RDLab_HaierDW40L508DeepFreezer40c20c> Items = await _context.RDLab_HaierDW40L508DeepFreezer40c20c.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_HaierDW40L508DeepFreezer40c20c> payload)
        {
            RDLab_HaierDW40L508DeepFreezer40c20c rDLab_HaierDW40L508DeepFreezer40c20c = payload.value;
            _context.RDLab_HaierDW40L508DeepFreezer40c20c.Add(rDLab_HaierDW40L508DeepFreezer40c20c);
            _context.SaveChanges();
            return Ok(rDLab_HaierDW40L508DeepFreezer40c20c);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_HaierDW40L508DeepFreezer40c20c> payload)
        {
            RDLab_HaierDW40L508DeepFreezer40c20c rDLab_HaierDW40L508DeepFreezer40c20c = payload.value;
            _context.RDLab_HaierDW40L508DeepFreezer40c20c.Update(rDLab_HaierDW40L508DeepFreezer40c20c);
            _context.SaveChanges();
            return Ok(rDLab_HaierDW40L508DeepFreezer40c20c);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_HaierDW40L508DeepFreezer40c20c> payload)
        {
            RDLab_HaierDW40L508DeepFreezer40c20c rDLab_HaierDW40L508DeepFreezer40c20c = _context.RDLab_HaierDW40L508DeepFreezer40c20c
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_HaierDW40L508DeepFreezer40c20c.Remove(rDLab_HaierDW40L508DeepFreezer40c20c);
            _context.SaveChanges();
            return Ok(rDLab_HaierDW40L508DeepFreezer40c20c);

        }
    }
}