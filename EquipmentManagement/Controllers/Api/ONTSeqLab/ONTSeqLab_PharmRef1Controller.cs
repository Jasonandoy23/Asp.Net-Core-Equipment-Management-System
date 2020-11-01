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
    [Route("api/ONTSeqLab_PharmRef1")]
    public class ONTSeqLab_PharmRef1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_PharmRef1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_PharmRef1
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_PharmRef1()
        {
            List<ONTSeqLab_PharmRef1> Items = await _context.ONTSeqLab_PharmRef1.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_PharmRef1> payload)
        {
            ONTSeqLab_PharmRef1 oNTSeqLab_PharmRef1 = payload.value;
            _context.ONTSeqLab_PharmRef1.Add(oNTSeqLab_PharmRef1);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PharmRef1);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_PharmRef1> payload)
        {
            ONTSeqLab_PharmRef1 oNTSeqLab_PharmRef1 = payload.value;
            _context.ONTSeqLab_PharmRef1.Update(oNTSeqLab_PharmRef1);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PharmRef1);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_PharmRef1> payload)
        {
            ONTSeqLab_PharmRef1 oNTSeqLab_PharmRef1 = _context.ONTSeqLab_PharmRef1
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_PharmRef1.Remove(oNTSeqLab_PharmRef1);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PharmRef1);

        }
    }
}