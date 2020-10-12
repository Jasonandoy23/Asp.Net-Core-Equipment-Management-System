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
    [Route("api/Condition")]
    public class ConditionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConditionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Condition
        [HttpGet]
        public async Task<IActionResult> GetCondition()
        {
            List<Condition> Items = await _context.Condition.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Condition> payload)
        {
            Condition condition = payload.value;
            _context.Condition.Add(condition);
            _context.SaveChanges();
            return Ok(condition);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Condition> payload)
        {
            Condition condition = payload.value;
            _context.Condition.Update(condition);
            _context.SaveChanges();
            return Ok(condition);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Condition> payload)
        {
            Condition condition = _context.Condition
                .Where(x => x.Condition_id == (long)payload.key)
                .FirstOrDefault();
            _context.Condition.Remove(condition);
            _context.SaveChanges();
            return Ok(condition);

        }
    }
}