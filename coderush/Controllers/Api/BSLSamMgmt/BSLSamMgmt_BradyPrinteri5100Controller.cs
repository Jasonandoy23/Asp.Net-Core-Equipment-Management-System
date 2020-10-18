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
    [Route("api/BSLSamMgmt_BradyPrinteri5100")]
    public class BSLSamMgmt_BradyPrinteri5100Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_BradyPrinteri5100Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_BradyPrinteri5100
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_BradyPrinteri5100()
        {
            List<BSLSamMgmt_BradyPrinteri5100> Items = await _context.BSLSamMgmt_BradyPrinteri5100.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_BradyPrinteri5100> payload)
        {
            BSLSamMgmt_BradyPrinteri5100 bSLSamMgmt_BradyPrinteri5100 = payload.value;
            _context.BSLSamMgmt_BradyPrinteri5100.Add(bSLSamMgmt_BradyPrinteri5100);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_BradyPrinteri5100);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_BradyPrinteri5100> payload)
        {
            BSLSamMgmt_BradyPrinteri5100 bSLSamMgmt_BradyPrinteri5100 = payload.value;
            _context.BSLSamMgmt_BradyPrinteri5100.Update(bSLSamMgmt_BradyPrinteri5100);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_BradyPrinteri5100);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_BradyPrinteri5100> payload)
        {
            BSLSamMgmt_BradyPrinteri5100 bSLSamMgmt_BradyPrinteri5100 = _context.BSLSamMgmt_BradyPrinteri5100
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_BradyPrinteri5100.Remove(bSLSamMgmt_BradyPrinteri5100);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_BradyPrinteri5100);

        }
    }
}