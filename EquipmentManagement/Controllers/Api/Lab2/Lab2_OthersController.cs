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
    [Route("api/Lab2_Others")]
    public class Lab2_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Lab2_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lab2_Others
        [HttpGet]
        public async Task<IActionResult> GetLab2_Others()
        {
            List<Lab2_Others> Items = await _context.Lab2_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Lab2_Others> payload)
        {
            Lab2_Others lab2_Others = payload.value;
            _context.Lab2_Others.Add(lab2_Others);
            _context.SaveChanges();
            return Ok(lab2_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Lab2_Others> payload)
        {
            Lab2_Others lab2_Others = payload.value;
            _context.Lab2_Others.Update(lab2_Others);
            _context.SaveChanges();
            return Ok(lab2_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Lab2_Others> payload)
        {
            Lab2_Others lab2_Others = _context.Lab2_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.Lab2_Others.Remove(lab2_Others);
            _context.SaveChanges();
            return Ok(lab2_Others);

        }
    }
}