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
    [Route("api/Lab4_Others")]
    public class Lab4_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab4_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab4_Others
        [HttpGet]
        public async Task<IActionResult> GetLab4_Others()
        {
            List<Lab4_Others> Items = await _context.Lab4_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab4_Others> payload)
        {
            Lab4_Others lab4_Others = payload.value;
            _context.Lab4_Others.Add(lab4_Others);
            _context.SaveChanges();
            return Ok(lab4_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab4_Others> payload)
        {
            Lab4_Others lab4_Others = payload.value;
            _context.Lab4_Others.Update(lab4_Others);
            _context.SaveChanges();
            return Ok(lab4_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab4_Others> payload)
        {
            Lab4_Others lab4_Others = _context.Lab4_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab4_Others.Remove(lab4_Others);
            _context.SaveChanges();
            return Ok(lab4_Others);

        }
    }
}