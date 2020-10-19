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
    [Route("api/RDLab_CompactDrybathS")]
    public class RDLab_CompactDrybathSController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_CompactDrybathSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_CompactDrybathS
        [HttpGet]
        public async Task<IActionResult> GetRDLab_CompactDrybathS()
        {
            List<RDLab_CompactDrybathS> Items = await _context.RDLab_CompactDrybathS.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_CompactDrybathS> payload)
        {
            RDLab_CompactDrybathS rDLab_CompactDrybathS = payload.value;
            _context.RDLab_CompactDrybathS.Add(rDLab_CompactDrybathS);
            _context.SaveChanges();
            return Ok(rDLab_CompactDrybathS);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_CompactDrybathS> payload)
        {
            RDLab_CompactDrybathS rDLab_CompactDrybathS = payload.value;
            _context.RDLab_CompactDrybathS.Update(rDLab_CompactDrybathS);
            _context.SaveChanges();
            return Ok(rDLab_CompactDrybathS);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_CompactDrybathS> payload)
        {
            RDLab_CompactDrybathS rDLab_CompactDrybathS = _context.RDLab_CompactDrybathS
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_CompactDrybathS.Remove(rDLab_CompactDrybathS);
            _context.SaveChanges();
            return Ok(rDLab_CompactDrybathS);

        }
    }
}