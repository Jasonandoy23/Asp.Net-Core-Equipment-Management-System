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
    [Route("api/BSLSamMgmt_DellDeskComp")]
    public class BSLSamMgmt_DellDeskCompController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_DellDeskCompController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_DellDeskComp
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_DellDeskComp()
        {
            List<BSLSamMgmt_DellDeskComp> Items = await _context.BSLSamMgmt_DellDeskComp.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_DellDeskComp> payload)
        {
            BSLSamMgmt_DellDeskComp bSLSamMgmt_DellDeskComp = payload.value;
            _context.BSLSamMgmt_DellDeskComp.Add(bSLSamMgmt_DellDeskComp);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_DellDeskComp> payload)
        {
            BSLSamMgmt_DellDeskComp bSLSamMgmt_DellDeskComp = payload.value;
            _context.BSLSamMgmt_DellDeskComp.Update(bSLSamMgmt_DellDeskComp);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_DellDeskComp);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_DellDeskComp> payload)
        {
            BSLSamMgmt_DellDeskComp bSLSamMgmt_DellDeskComp = _context.BSLSamMgmt_DellDeskComp
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_DellDeskComp.Remove(bSLSamMgmt_DellDeskComp);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_DellDeskComp);

        }
    }
}