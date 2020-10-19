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
    [Route("api/RDLab_ThermoScientificMyspin6")]
    public class RDLab_ThermoScientificMyspin6Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_ThermoScientificMyspin6Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_ThermoScientificMyspin6
        [HttpGet]
        public async Task<IActionResult> GetRDLab_ThermoScientificMyspin6()
        {
            List<RDLab_ThermoScientificMyspin6> Items = await _context.RDLab_ThermoScientificMyspin6.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_ThermoScientificMyspin6> payload)
        {
            RDLab_ThermoScientificMyspin6 rDLab_ThermoScientificMyspin6 = payload.value;
            _context.RDLab_ThermoScientificMyspin6.Add(rDLab_ThermoScientificMyspin6);
            _context.SaveChanges();
            return Ok(rDLab_ThermoScientificMyspin6);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_ThermoScientificMyspin6> payload)
        {
            RDLab_ThermoScientificMyspin6 rDLab_ThermoScientificMyspin6 = payload.value;
            _context.RDLab_ThermoScientificMyspin6.Update(rDLab_ThermoScientificMyspin6);
            _context.SaveChanges();
            return Ok(rDLab_ThermoScientificMyspin6);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_ThermoScientificMyspin6> payload)
        {
            RDLab_ThermoScientificMyspin6 rDLab_ThermoScientificMyspin6 = _context.RDLab_ThermoScientificMyspin6
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_ThermoScientificMyspin6.Remove(rDLab_ThermoScientificMyspin6);
            _context.SaveChanges();
            return Ok(rDLab_ThermoScientificMyspin6);

        }
    }
}