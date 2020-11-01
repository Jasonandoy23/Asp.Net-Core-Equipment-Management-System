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
    [Route("api/ONTLibConstLab_MicroLabNGSSTAR")]
    public class ONTLibConstLab_MicroLabNGSSTARController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTLibConstLab_MicroLabNGSSTARController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTLibConstLab_MicroLabNGSSTAR
        [HttpGet]
        public async Task<IActionResult> GetONTLibConstLab_MicroLabNGSSTAR()
        {
            List<ONTLibConstLab_MicroLabNGSSTAR> Items = await _context.ONTLibConstLab_MicroLabNGSSTAR.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTLibConstLab_MicroLabNGSSTAR> payload)
        {
            ONTLibConstLab_MicroLabNGSSTAR oNTLibConstLab_MicroLabNGSSTAR = payload.value;
            _context.ONTLibConstLab_MicroLabNGSSTAR.Add(oNTLibConstLab_MicroLabNGSSTAR);
            _context.SaveChanges();
            return Ok(oNTLibConstLab_MicroLabNGSSTAR);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTLibConstLab_MicroLabNGSSTAR> payload)
        {
            ONTLibConstLab_MicroLabNGSSTAR oNTLibConstLab_MicroLabNGSSTAR = payload.value;
            _context.ONTLibConstLab_MicroLabNGSSTAR.Update(oNTLibConstLab_MicroLabNGSSTAR);
            _context.SaveChanges();
            return Ok(oNTLibConstLab_MicroLabNGSSTAR);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTLibConstLab_MicroLabNGSSTAR> payload)
        {
            ONTLibConstLab_MicroLabNGSSTAR oNTLibConstLab_MicroLabNGSSTAR = _context.ONTLibConstLab_MicroLabNGSSTAR
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTLibConstLab_MicroLabNGSSTAR.Remove(oNTLibConstLab_MicroLabNGSSTAR);
            _context.SaveChanges();
            return Ok(oNTLibConstLab_MicroLabNGSSTAR);

        }
    }
}