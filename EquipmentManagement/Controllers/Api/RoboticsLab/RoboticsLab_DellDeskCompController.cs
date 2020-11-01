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
    [Route("api/RoboticsLab_DellDeskComp")]
    public class RoboticsLab_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoboticsLab_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RoboticsLab_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetRoboticsLab_DellDeskComp()
        {
            List<RoboticsLab_DellDeskComp> Items = await _context.RoboticsLab_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RoboticsLab_DellDeskComp> payload)
        {
            RoboticsLab_DellDeskComp roboticsLab_DellDeskComp = payload.value;
            _context.RoboticsLab_DellDeskComp.Add(roboticsLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(roboticsLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RoboticsLab_DellDeskComp> payload)
        {
            RoboticsLab_DellDeskComp roboticsLab_DellDeskComp = payload.value;
            _context.RoboticsLab_DellDeskComp.Update(roboticsLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(roboticsLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RoboticsLab_DellDeskComp> payload)
        {
            RoboticsLab_DellDeskComp roboticsLab_DellDeskComp = _context.RoboticsLab_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RoboticsLab_DellDeskComp.Remove(roboticsLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(roboticsLab_DellDeskComp);

        }
    }
}