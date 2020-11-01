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
    [Route("api/RoboticsLab_Others")]
    public class RoboticsLab_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoboticsLab_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RoboticsLab_Others
        [HttpGet]
        public async Task<IActionResult> GetRoboticsLab_Others()
        {
            List<RoboticsLab_Others> Items = await _context.RoboticsLab_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RoboticsLab_Others> payload)
        {
            RoboticsLab_Others roboticsLab_Others = payload.value;
            _context.RoboticsLab_Others.Add(roboticsLab_Others);
            _context.SaveChanges();
            return Ok(roboticsLab_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RoboticsLab_Others> payload)
        {
            RoboticsLab_Others roboticsLab_Others = payload.value;
            _context.RoboticsLab_Others.Update(roboticsLab_Others);
            _context.SaveChanges();
            return Ok(roboticsLab_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RoboticsLab_Others> payload)
        {
            RoboticsLab_Others roboticsLab_Others = _context.RoboticsLab_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RoboticsLab_Others.Remove(roboticsLab_Others);
            _context.SaveChanges();
            return Ok(roboticsLab_Others);

        }
    }
}