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
    [Route("api/ONTSeqLab_Centrifuge5424")]
    public class ONTSeqLab_Centrifuge5424Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_Centrifuge5424Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_Centrifuge5424
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_Centrifuge5424()
        {
            List<ONTSeqLab_Centrifuge5424> Items = await _context.ONTSeqLab_Centrifuge5424.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_Centrifuge5424> payload)
        {
            ONTSeqLab_Centrifuge5424 oNTSeqLab_Centrifuge5424 = payload.value;
            _context.ONTSeqLab_Centrifuge5424.Add(oNTSeqLab_Centrifuge5424);
            _context.SaveChanges();
            return Ok(oNTSeqLab_Centrifuge5424);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_Centrifuge5424> payload)
        {
            ONTSeqLab_Centrifuge5424 oNTSeqLab_Centrifuge5424 = payload.value;
            _context.ONTSeqLab_Centrifuge5424.Update(oNTSeqLab_Centrifuge5424);
            _context.SaveChanges();
            return Ok(oNTSeqLab_Centrifuge5424);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_Centrifuge5424> payload)
        {
            ONTSeqLab_Centrifuge5424 oNTSeqLab_Centrifuge5424 = _context.ONTSeqLab_Centrifuge5424
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_Centrifuge5424.Remove(oNTSeqLab_Centrifuge5424);
            _context.SaveChanges();
            return Ok(oNTSeqLab_Centrifuge5424);

        }
    }
}