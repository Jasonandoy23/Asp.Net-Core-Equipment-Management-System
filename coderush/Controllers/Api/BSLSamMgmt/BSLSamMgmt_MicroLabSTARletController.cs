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
    [Route("api/BSLSamMgmt_MicroLabSTARlet")]
    public class BSLSamMgmt_MicroLabSTARletController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_MicroLabSTARletController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_MicroLabSTARlet
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_MicroLabSTARlet()
        {
            List<BSLSamMgmt_MicroLabSTARlet> Items = await _context.BSLSamMgmt_MicroLabSTARlet.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_MicroLabSTARlet> payload)
        {
            BSLSamMgmt_MicroLabSTARlet bSLSamMgmt_MicroLabSTARlet = payload.value;
            _context.BSLSamMgmt_MicroLabSTARlet.Add(bSLSamMgmt_MicroLabSTARlet);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_MicroLabSTARlet);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_MicroLabSTARlet> payload)
        {
            BSLSamMgmt_MicroLabSTARlet bSLSamMgmt_MicroLabSTARlet = payload.value;
            _context.BSLSamMgmt_MicroLabSTARlet.Update(bSLSamMgmt_MicroLabSTARlet);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_MicroLabSTARlet);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_MicroLabSTARlet> payload)
        {
            BSLSamMgmt_MicroLabSTARlet bSLSamMgmt_MicroLabSTARlet = _context.BSLSamMgmt_MicroLabSTARlet
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_MicroLabSTARlet.Remove(bSLSamMgmt_MicroLabSTARlet);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_MicroLabSTARlet);

        }
    }
}