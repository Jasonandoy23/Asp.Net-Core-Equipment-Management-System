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
    [Route("api/BSLSamMgmt_STPlusSeriesCentrifuge")]
    public class BSLSamMgmt_STPlusSeriesCentrifugeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_STPlusSeriesCentrifugeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_STPlusSeriesCentrifuge
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_STPlusSeriesCentrifuge()
        {
            List<BSLSamMgmt_STPlusSeriesCentrifuge> Items = await _context.BSLSamMgmt_STPlusSeriesCentrifuge.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_STPlusSeriesCentrifuge> payload)
        {
            BSLSamMgmt_STPlusSeriesCentrifuge bSLSamMgmt_STPlusSeriesCentrifuge = payload.value;
            _context.BSLSamMgmt_STPlusSeriesCentrifuge.Add(bSLSamMgmt_STPlusSeriesCentrifuge);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_STPlusSeriesCentrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_STPlusSeriesCentrifuge> payload)
        {
            BSLSamMgmt_STPlusSeriesCentrifuge bSLSamMgmt_STPlusSeriesCentrifuge = payload.value;
            _context.BSLSamMgmt_STPlusSeriesCentrifuge.Update(bSLSamMgmt_STPlusSeriesCentrifuge);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_STPlusSeriesCentrifuge);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_STPlusSeriesCentrifuge> payload)
        {
            BSLSamMgmt_STPlusSeriesCentrifuge bSLSamMgmt_STPlusSeriesCentrifuge = _context.BSLSamMgmt_STPlusSeriesCentrifuge
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_STPlusSeriesCentrifuge.Remove(bSLSamMgmt_STPlusSeriesCentrifuge);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_STPlusSeriesCentrifuge);

        }
    }
}