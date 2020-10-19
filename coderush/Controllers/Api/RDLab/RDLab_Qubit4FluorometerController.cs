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
    [Route("api/RDLab_Qubit4Fluorometer")]
    public class RDLab_Qubit4FluorometerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_Qubit4FluorometerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_Qubit4Fluorometer
        [HttpGet]
        public async Task<IActionResult> GetRDLab_Qubit4Fluorometer()
        {
            List<RDLab_Qubit4Fluorometer> Items = await _context.RDLab_Qubit4Fluorometer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_Qubit4Fluorometer> payload)
        {
            RDLab_Qubit4Fluorometer rDLab_Qubit4Fluorometer = payload.value;
            _context.RDLab_Qubit4Fluorometer.Add(rDLab_Qubit4Fluorometer);
            _context.SaveChanges();
            return Ok(rDLab_Qubit4Fluorometer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_Qubit4Fluorometer> payload)
        {
            RDLab_Qubit4Fluorometer rDLab_Qubit4Fluorometer = payload.value;
            _context.RDLab_Qubit4Fluorometer.Update(rDLab_Qubit4Fluorometer);
            _context.SaveChanges();
            return Ok(rDLab_Qubit4Fluorometer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_Qubit4Fluorometer> payload)
        {
            RDLab_Qubit4Fluorometer rDLab_Qubit4Fluorometer = _context.RDLab_Qubit4Fluorometer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_Qubit4Fluorometer.Remove(rDLab_Qubit4Fluorometer);
            _context.SaveChanges();
            return Ok(rDLab_Qubit4Fluorometer);

        }
    }
}