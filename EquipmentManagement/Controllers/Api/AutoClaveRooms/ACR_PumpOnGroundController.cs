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
    [Route("api/ACR_PumpOnGround")]
    public class ACR_PumpOnGroundController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ACR_PumpOnGroundController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ACR_PumpOnGround
        [HttpGet]
        public async Task<IActionResult> GetACR_PumpOnGround()
        {
            List<ACR_PumpOnGround> Items = await _context.ACR_PumpOnGround.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ACR_PumpOnGround> payload)
        {
            ACR_PumpOnGround ACR_PumpOnGround = payload.value;
            _context.ACR_PumpOnGround.Add(ACR_PumpOnGround);
            _context.SaveChanges();
            return Ok(ACR_PumpOnGround);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ACR_PumpOnGround> payload)
        {
            ACR_PumpOnGround ACR_PumpOnGround = payload.value;
            _context.ACR_PumpOnGround.Update(ACR_PumpOnGround);
            _context.SaveChanges();
            return Ok(ACR_PumpOnGround);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ACR_PumpOnGround> payload)
        {
            ACR_PumpOnGround ACR_PumpOnGround = _context.ACR_PumpOnGround
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ACR_PumpOnGround.Remove(ACR_PumpOnGround);
            _context.SaveChanges();
            return Ok(ACR_PumpOnGround);

        }
    }
}