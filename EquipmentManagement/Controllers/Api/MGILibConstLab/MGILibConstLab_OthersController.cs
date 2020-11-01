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
    [Route("api/MGILibConstLab_Others")]
    public class MGILibConstLab_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MGILibConstLab_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MGILibConstLab_Others
        [HttpGet]
        public async Task<IActionResult> GetMGILibConstLab_Others()
        {
            List<MGILibConstLab_Others> Items = await _context.MGILibConstLab_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<MGILibConstLab_Others> payload)
        {
            MGILibConstLab_Others mGILibConstLab_Others = payload.value;
            _context.MGILibConstLab_Others.Add(mGILibConstLab_Others);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<MGILibConstLab_Others> payload)
        {
            MGILibConstLab_Others mGILibConstLab_Others = payload.value;
            _context.MGILibConstLab_Others.Update(mGILibConstLab_Others);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<MGILibConstLab_Others> payload)
        {
            MGILibConstLab_Others mGILibConstLab_Others = _context.MGILibConstLab_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.MGILibConstLab_Others.Remove(mGILibConstLab_Others);
            _context.SaveChanges();
            return Ok(mGILibConstLab_Others);

        }
    }
}