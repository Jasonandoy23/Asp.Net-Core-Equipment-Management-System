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
    [Route("api/BSLSamMgmt_Centrifuge")]
    public class BSLSamMgmt_CentrifugeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_CentrifugeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_Centrifuge
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_Centrifuge()
        {
            List<BSLSamMgmt_Centrifuge> Items = await _context.BSLSamMgmt_Centrifuge.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_Centrifuge> payload)
        {
            BSLSamMgmt_Centrifuge bSLSamMgmt_Centrifuge = payload.value;
            _context.BSLSamMgmt_Centrifuge.Add(bSLSamMgmt_Centrifuge);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Centrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_Centrifuge> payload)
        {
            BSLSamMgmt_Centrifuge bSLSamMgmt_Centrifuge = payload.value;
            _context.BSLSamMgmt_Centrifuge.Update(bSLSamMgmt_Centrifuge);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Centrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_Centrifuge> payload)
        {
            BSLSamMgmt_Centrifuge bSLSamMgmt_Centrifuge = _context.BSLSamMgmt_Centrifuge
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_Centrifuge.Remove(bSLSamMgmt_Centrifuge);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Centrifuge);

        }
    }
}