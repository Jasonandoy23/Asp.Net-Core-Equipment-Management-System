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
    [Route("api/RDLab_PrecisionGP10WaterBath")]
    public class RDLab_PrecisionGP10WaterBathController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_PrecisionGP10WaterBathController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_PrecisionGP10WaterBath
        [HttpGet]
        public async Task<IActionResult> GetRDLab_PrecisionGP10WaterBath()
        {
            List<RDLab_PrecisionGP10WaterBath> Items = await _context.RDLab_PrecisionGP10WaterBath.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_PrecisionGP10WaterBath> payload)
        {
            RDLab_PrecisionGP10WaterBath rDLab_PrecisionGP10WaterBath = payload.value;
            _context.RDLab_PrecisionGP10WaterBath.Add(rDLab_PrecisionGP10WaterBath);
            _context.SaveChanges();
            return Ok(rDLab_PrecisionGP10WaterBath);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_PrecisionGP10WaterBath> payload)
        {
            RDLab_PrecisionGP10WaterBath rDLab_PrecisionGP10WaterBath = payload.value;
            _context.RDLab_PrecisionGP10WaterBath.Update(rDLab_PrecisionGP10WaterBath);
            _context.SaveChanges();
            return Ok(rDLab_PrecisionGP10WaterBath);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_PrecisionGP10WaterBath> payload)
        {
            RDLab_PrecisionGP10WaterBath rDLab_PrecisionGP10WaterBath = _context.RDLab_PrecisionGP10WaterBath
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_PrecisionGP10WaterBath.Remove(rDLab_PrecisionGP10WaterBath);
            _context.SaveChanges();
            return Ok(rDLab_PrecisionGP10WaterBath);

        }
    }
}