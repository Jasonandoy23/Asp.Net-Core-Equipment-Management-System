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
    [Route("api/ConsumablesAndLabware")]
    public class ConsumablesAndLabwareController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsumablesAndLabwareController(ApplicationDbContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public async Task<IActionResult> GetConsumablesAndLabware()
        {
            List<ConsumablesAndLabware> Items = await _context.ConsumablesAndLabware.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ConsumablesAndLabware> payload)
        {
            ConsumablesAndLabware consumablesAndLabware = payload.value;
            _context.ConsumablesAndLabware.Add(consumablesAndLabware);
            _context.SaveChanges();
            return Ok(consumablesAndLabware);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ConsumablesAndLabware> payload)
        {
            ConsumablesAndLabware consumablesAndLabware = payload.value;
            _context.ConsumablesAndLabware.Update(consumablesAndLabware);
            _context.SaveChanges();
            return Ok(consumablesAndLabware);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ConsumablesAndLabware> payload)
        {
            ConsumablesAndLabware consumablesAndLabware = _context.ConsumablesAndLabware
                .Where(x => x.CL_id == (long)payload.key)
                .FirstOrDefault();
            _context.ConsumablesAndLabware.Remove(consumablesAndLabware);
            _context.SaveChanges();
            return Ok(consumablesAndLabware);

        }
        
    }
}