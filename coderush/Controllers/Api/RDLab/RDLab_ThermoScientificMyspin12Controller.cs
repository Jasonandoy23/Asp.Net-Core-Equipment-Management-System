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
    [Route("api/RDLab_ThermoScientificMyspin12")]
    public class RDLab_ThermoScientificMyspin12Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_ThermoScientificMyspin12Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_ThermoScientificMyspin12
        [HttpGet]
        public async Task<IActionResult> GetRDLab_ThermoScientificMyspin12()
        {
            List<RDLab_ThermoScientificMyspin12> Items = await _context.RDLab_ThermoScientificMyspin12.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_ThermoScientificMyspin12> payload)
        {
            RDLab_ThermoScientificMyspin12 rDLab_ThermoScientificMyspin12 = payload.value;
            _context.RDLab_ThermoScientificMyspin12.Add(rDLab_ThermoScientificMyspin12);
            _context.SaveChanges();
            return Ok(rDLab_ThermoScientificMyspin12);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_ThermoScientificMyspin12> payload)
        {
            RDLab_ThermoScientificMyspin12 rDLab_ThermoScientificMyspin12 = payload.value;
            _context.RDLab_ThermoScientificMyspin12.Update(rDLab_ThermoScientificMyspin12);
            _context.SaveChanges();
            return Ok(rDLab_ThermoScientificMyspin12);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_ThermoScientificMyspin12> payload)
        {
            RDLab_ThermoScientificMyspin12 rDLab_ThermoScientificMyspin12 = _context.RDLab_ThermoScientificMyspin12
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_ThermoScientificMyspin12.Remove(rDLab_ThermoScientificMyspin12);
            _context.SaveChanges();
            return Ok(rDLab_ThermoScientificMyspin12);

        }
    }
}