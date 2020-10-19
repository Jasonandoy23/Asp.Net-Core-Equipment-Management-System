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
    [Route("api/ONTSeqLab_DellDeskComp")]
    public class ONTSeqLab_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_DellDeskComp()
        {
            List<ONTSeqLab_DellDeskComp> Items = await _context.ONTSeqLab_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_DellDeskComp> payload)
        {
            ONTSeqLab_DellDeskComp oNTSeqLab_DellDeskComp = payload.value;
            _context.ONTSeqLab_DellDeskComp.Add(oNTSeqLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(oNTSeqLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_DellDeskComp> payload)
        {
            ONTSeqLab_DellDeskComp oNTSeqLab_DellDeskComp = payload.value;
            _context.ONTSeqLab_DellDeskComp.Update(oNTSeqLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(oNTSeqLab_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_DellDeskComp> payload)
        {
            ONTSeqLab_DellDeskComp oNTSeqLab_DellDeskComp = _context.ONTSeqLab_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_DellDeskComp.Remove(oNTSeqLab_DellDeskComp);
            _context.SaveChanges();
            return Ok(oNTSeqLab_DellDeskComp);

        }
    }
}