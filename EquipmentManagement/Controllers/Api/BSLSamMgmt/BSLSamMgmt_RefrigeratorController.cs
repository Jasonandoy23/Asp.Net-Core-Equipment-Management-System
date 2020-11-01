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
    [Route("api/BSLSamMgmt_Refrigerator")]
    public class BSLSamMgmt_RefrigeratorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_RefrigeratorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_Refrigerator
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_Refrigerator()
        {
            List<BSLSamMgmt_Refrigerator> Items = await _context.BSLSamMgmt_Refrigerator.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_Refrigerator> payload)
        {
            BSLSamMgmt_Refrigerator bSLSamMgmt_Refrigerator = payload.value;
            _context.BSLSamMgmt_Refrigerator.Add(bSLSamMgmt_Refrigerator);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Refrigerator);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_Refrigerator> payload)
        {
            BSLSamMgmt_Refrigerator bSLSamMgmt_Refrigerator = payload.value;
            _context.BSLSamMgmt_Refrigerator.Update(bSLSamMgmt_Refrigerator);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Refrigerator);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_Refrigerator> payload)
        {
            BSLSamMgmt_Refrigerator bSLSamMgmt_Refrigerator = _context.BSLSamMgmt_Refrigerator
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_Refrigerator.Remove(bSLSamMgmt_Refrigerator);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_Refrigerator);

        }
    }
}