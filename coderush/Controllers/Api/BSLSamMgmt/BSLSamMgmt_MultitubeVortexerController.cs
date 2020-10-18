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
    [Route("api/BSLSamMgmt_MultitubeVortexer")]
    public class BSLSamMgmt_MultitubeVortexerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_MultitubeVortexerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_MultitubeVortexer
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_MultitubeVortexer()
        {
            List<BSLSamMgmt_MultitubeVortexer> Items = await _context.BSLSamMgmt_MultitubeVortexer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_MultitubeVortexer> payload)
        {
            BSLSamMgmt_MultitubeVortexer bSLSamMgmt_MultitubeVortexer = payload.value;
            _context.BSLSamMgmt_MultitubeVortexer.Add(bSLSamMgmt_MultitubeVortexer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_MultitubeVortexer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_MultitubeVortexer> payload)
        {
            BSLSamMgmt_MultitubeVortexer bSLSamMgmt_MultitubeVortexer = payload.value;
            _context.BSLSamMgmt_MultitubeVortexer.Update(bSLSamMgmt_MultitubeVortexer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_MultitubeVortexer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_MultitubeVortexer> payload)
        {
            BSLSamMgmt_MultitubeVortexer bSLSamMgmt_MultitubeVortexer = _context.BSLSamMgmt_MultitubeVortexer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_MultitubeVortexer.Remove(bSLSamMgmt_MultitubeVortexer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_MultitubeVortexer);

        }
    }
}