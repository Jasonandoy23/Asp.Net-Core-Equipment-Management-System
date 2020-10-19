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
    [Route("api/ONTSeqLab_ThermofisherSciFridge")]
    public class ONTSeqLab_ThermofisherSciFridgeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_ThermofisherSciFridgeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_ThermofisherSciFridge
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_ThermofisherSciFridge()
        {
            List<ONTSeqLab_ThermofisherSciFridge> Items = await _context.ONTSeqLab_ThermofisherSciFridge.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_ThermofisherSciFridge> payload)
        {
            ONTSeqLab_ThermofisherSciFridge oNTSeqLab_ThermofisherSciFridge = payload.value;
            _context.ONTSeqLab_ThermofisherSciFridge.Add(oNTSeqLab_ThermofisherSciFridge);
            _context.SaveChanges();
            return Ok(oNTSeqLab_ThermofisherSciFridge);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_ThermofisherSciFridge> payload)
        {
            ONTSeqLab_ThermofisherSciFridge oNTSeqLab_ThermofisherSciFridge = payload.value;
            _context.ONTSeqLab_ThermofisherSciFridge.Update(oNTSeqLab_ThermofisherSciFridge);
            _context.SaveChanges();
            return Ok(oNTSeqLab_ThermofisherSciFridge);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_ThermofisherSciFridge> payload)
        {
            ONTSeqLab_ThermofisherSciFridge oNTSeqLab_ThermofisherSciFridge = _context.ONTSeqLab_ThermofisherSciFridge
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_ThermofisherSciFridge.Remove(oNTSeqLab_ThermofisherSciFridge);
            _context.SaveChanges();
            return Ok(oNTSeqLab_ThermofisherSciFridge);

        }
    }
}