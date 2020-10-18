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
    [Route("api/BSLSamMgmt_CenceCentrifugeCL5R")]
    public class BSLSamMgmt_CenceCentrifugeCL5RController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_CenceCentrifugeCL5RController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_CenceCentrifugeCL5R
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_CenceCentrifugeCL5R()
        {
            List<BSLSamMgmt_CenceCentrifugeCL5R> Items = await _context.BSLSamMgmt_CenceCentrifugeCL5R.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_CenceCentrifugeCL5R> payload)
        {
            BSLSamMgmt_CenceCentrifugeCL5R bSLSamMgmt_CenceCentrifugeCL5R = payload.value;
            _context.BSLSamMgmt_CenceCentrifugeCL5R.Add(bSLSamMgmt_CenceCentrifugeCL5R);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_CenceCentrifugeCL5R);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_CenceCentrifugeCL5R> payload)
        {
            BSLSamMgmt_CenceCentrifugeCL5R bSLSamMgmt_CenceCentrifugeCL5R = payload.value;
            _context.BSLSamMgmt_CenceCentrifugeCL5R.Update(bSLSamMgmt_CenceCentrifugeCL5R);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_CenceCentrifugeCL5R);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_CenceCentrifugeCL5R> payload)
        {
            BSLSamMgmt_CenceCentrifugeCL5R bSLSamMgmt_CenceCentrifugeCL5R = _context.BSLSamMgmt_CenceCentrifugeCL5R
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_CenceCentrifugeCL5R.Remove(bSLSamMgmt_CenceCentrifugeCL5R);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_CenceCentrifugeCL5R);

        }
    }
}