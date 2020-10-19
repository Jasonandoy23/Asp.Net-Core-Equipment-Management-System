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
    [Route("api/RDLab_Centrifuge5424R")]
    public class RDLab_Centrifuge5424RController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_Centrifuge5424RController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_Centrifuge5424R
        [HttpGet]
        public async Task<IActionResult> GetRDLab_Centrifuge5424R()
        {
            List<RDLab_Centrifuge5424R> Items = await _context.RDLab_Centrifuge5424R.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_Centrifuge5424R> payload)
        {
            RDLab_Centrifuge5424R rDLab_Centrifuge5424R = payload.value;
            _context.RDLab_Centrifuge5424R.Add(rDLab_Centrifuge5424R);
            _context.SaveChanges();
            return Ok(rDLab_Centrifuge5424R);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_Centrifuge5424R> payload)
        {
            RDLab_Centrifuge5424R rDLab_Centrifuge5424R = payload.value;
            _context.RDLab_Centrifuge5424R.Update(rDLab_Centrifuge5424R);
            _context.SaveChanges();
            return Ok(rDLab_Centrifuge5424R);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_Centrifuge5424R> payload)
        {
            RDLab_Centrifuge5424R rDLab_Centrifuge5424R = _context.RDLab_Centrifuge5424R
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_Centrifuge5424R.Remove(rDLab_Centrifuge5424R);
            _context.SaveChanges();
            return Ok(rDLab_Centrifuge5424R);

        }
    }
}