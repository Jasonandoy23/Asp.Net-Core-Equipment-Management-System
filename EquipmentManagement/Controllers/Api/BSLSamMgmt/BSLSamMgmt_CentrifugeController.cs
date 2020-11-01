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
    [Route("api/BSLSamMgmt_Centrifuge5702")]
    public class BSLSamMgmt_Centrifuge5702Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_Centrifuge5702Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_Centrifuge5702
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_Centrifuge5702()
        {
            List<BSLSamMgmt_Centrifuge5702> Items = await _context.BSLSamMgmt_Centrifuge5702.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_Centrifuge5702> payload)
        {
            BSLSamMgmt_Centrifuge5702 bSLSamMgmt_Centrifuge5702 = payload.value;
            _context.BSLSamMgmt_Centrifuge5702.Add(bSLSamMgmt_Centrifuge5702);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Centrifuge5702);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_Centrifuge5702> payload)
        {
            BSLSamMgmt_Centrifuge5702 bSLSamMgmt_Centrifuge5702 = payload.value;
            _context.BSLSamMgmt_Centrifuge5702.Update(bSLSamMgmt_Centrifuge5702);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Centrifuge5702);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_Centrifuge5702> payload)
        {
            BSLSamMgmt_Centrifuge5702 bSLSamMgmt_Centrifuge5702 = _context.BSLSamMgmt_Centrifuge5702
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_Centrifuge5702.Remove(bSLSamMgmt_Centrifuge5702);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Centrifuge5702);

        }
    }
}