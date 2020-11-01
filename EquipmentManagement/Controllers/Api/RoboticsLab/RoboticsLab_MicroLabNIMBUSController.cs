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
    [Route("api/RoboticsLab_MicroLabNIMBUS")]
    public class RoboticsLab_MicroLabNIMBUSController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoboticsLab_MicroLabNIMBUSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RoboticsLab_MicroLabNIMBUS
        [HttpGet]
        public async Task<IActionResult> GetRoboticsLab_MicroLabNIMBUS()
        {
            List<RoboticsLab_MicroLabNIMBUS> Items = await _context.RoboticsLab_MicroLabNIMBUS.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RoboticsLab_MicroLabNIMBUS> payload)
        {
            RoboticsLab_MicroLabNIMBUS roboticsLab_MicroLabNIMBUS = payload.value;
            _context.RoboticsLab_MicroLabNIMBUS.Add(roboticsLab_MicroLabNIMBUS);
            _context.SaveChanges();
            return Ok(roboticsLab_MicroLabNIMBUS);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RoboticsLab_MicroLabNIMBUS> payload)
        {
            RoboticsLab_MicroLabNIMBUS roboticsLab_MicroLabNIMBUS = payload.value;
            _context.RoboticsLab_MicroLabNIMBUS.Update(roboticsLab_MicroLabNIMBUS);
            _context.SaveChanges();
            return Ok(roboticsLab_MicroLabNIMBUS);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RoboticsLab_MicroLabNIMBUS> payload)
        {
            RoboticsLab_MicroLabNIMBUS roboticsLab_MicroLabNIMBUS = _context.RoboticsLab_MicroLabNIMBUS
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RoboticsLab_MicroLabNIMBUS.Remove(roboticsLab_MicroLabNIMBUS);
            _context.SaveChanges();
            return Ok(roboticsLab_MicroLabNIMBUS);

        }
    }
}