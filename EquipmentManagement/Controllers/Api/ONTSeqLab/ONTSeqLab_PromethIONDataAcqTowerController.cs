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
    [Route("api/ONTSeqLab_PromethIONDataAcqTower")]
    public class ONTSeqLab_PromethIONDataAcqTowerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_PromethIONDataAcqTowerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_PromethIONDataAcqTower
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_PromethIONDataAcqTower()
        {
            List<ONTSeqLab_PromethIONDataAcqTower> Items = await _context.ONTSeqLab_PromethIONDataAcqTower.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_PromethIONDataAcqTower> payload)
        {
            ONTSeqLab_PromethIONDataAcqTower oNTSeqLab_PromethIONDataAcqTower = payload.value;
            _context.ONTSeqLab_PromethIONDataAcqTower.Add(oNTSeqLab_PromethIONDataAcqTower);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PromethIONDataAcqTower);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_PromethIONDataAcqTower> payload)
        {
            ONTSeqLab_PromethIONDataAcqTower oNTSeqLab_PromethIONDataAcqTower = payload.value;
            _context.ONTSeqLab_PromethIONDataAcqTower.Update(oNTSeqLab_PromethIONDataAcqTower);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PromethIONDataAcqTower);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_PromethIONDataAcqTower> payload)
        {
            ONTSeqLab_PromethIONDataAcqTower oNTSeqLab_PromethIONDataAcqTower = _context.ONTSeqLab_PromethIONDataAcqTower
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_PromethIONDataAcqTower.Remove(oNTSeqLab_PromethIONDataAcqTower);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PromethIONDataAcqTower);

        }
    }
}