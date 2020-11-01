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
    [Route("api/ONTSeqLab_PharmRef2")]
    public class ONTSeqLab_PharmRef2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_PharmRef2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_PharmRef2
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_PharmRef2()
        {
            List<ONTSeqLab_PharmRef2> Items = await _context.ONTSeqLab_PharmRef2.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_PharmRef2> payload)
        {
            ONTSeqLab_PharmRef2 oNTSeqLab_PharmRef2 = payload.value;
            _context.ONTSeqLab_PharmRef2.Add(oNTSeqLab_PharmRef2);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PharmRef2);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_PharmRef2> payload)
        {
            ONTSeqLab_PharmRef2 oNTSeqLab_PharmRef2 = payload.value;
            _context.ONTSeqLab_PharmRef2.Update(oNTSeqLab_PharmRef2);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PharmRef2);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_PharmRef2> payload)
        {
            ONTSeqLab_PharmRef2 oNTSeqLab_PharmRef2 = _context.ONTSeqLab_PharmRef2
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_PharmRef2.Remove(oNTSeqLab_PharmRef2);
            _context.SaveChanges();
            return Ok(oNTSeqLab_PharmRef2);

        }
    }
}