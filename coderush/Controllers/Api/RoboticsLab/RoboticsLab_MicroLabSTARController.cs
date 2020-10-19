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
    [Route("api/RoboticsLab_MicroLabSTAR")]
    public class RoboticsLab_MicroLabSTARController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoboticsLab_MicroLabSTARController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RoboticsLab_MicroLabSTAR
        [HttpGet]
        public async Task<IActionResult> GetRoboticsLab_MicroLabSTAR()
        {
            List<RoboticsLab_MicroLabSTAR> Items = await _context.RoboticsLab_MicroLabSTAR.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RoboticsLab_MicroLabSTAR> payload)
        {
            RoboticsLab_MicroLabSTAR roboticsLab_MicroLabSTAR = payload.value;
            _context.RoboticsLab_MicroLabSTAR.Add(roboticsLab_MicroLabSTAR);
            _context.SaveChanges();
            return Ok(roboticsLab_MicroLabSTAR);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RoboticsLab_MicroLabSTAR> payload)
        {
            RoboticsLab_MicroLabSTAR roboticsLab_MicroLabSTAR = payload.value;
            _context.RoboticsLab_MicroLabSTAR.Update(roboticsLab_MicroLabSTAR);
            _context.SaveChanges();
            return Ok(roboticsLab_MicroLabSTAR);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RoboticsLab_MicroLabSTAR> payload)
        {
            RoboticsLab_MicroLabSTAR roboticsLab_MicroLabSTAR = _context.RoboticsLab_MicroLabSTAR
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RoboticsLab_MicroLabSTAR.Remove(roboticsLab_MicroLabSTAR);
            _context.SaveChanges();
            return Ok(roboticsLab_MicroLabSTAR);

        }
    }
}