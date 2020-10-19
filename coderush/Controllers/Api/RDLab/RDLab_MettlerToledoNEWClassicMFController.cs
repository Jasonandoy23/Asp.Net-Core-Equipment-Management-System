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
    [Route("api/RDLab_MettlerToledoNEWClassicMF")]
    public class RDLab_MettlerToledoNEWClassicMFController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_MettlerToledoNEWClassicMFController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_MettlerToledoNEWClassicMF
        [HttpGet]
        public async Task<IActionResult> GetRDLab_MettlerToledoNEWClassicMF()
        {
            List<RDLab_MettlerToledoNEWClassicMF> Items = await _context.RDLab_MettlerToledoNEWClassicMF.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_MettlerToledoNEWClassicMF> payload)
        {
            RDLab_MettlerToledoNEWClassicMF rDLab_MettlerToledoNEWClassicMF = payload.value;
            _context.RDLab_MettlerToledoNEWClassicMF.Add(rDLab_MettlerToledoNEWClassicMF);
            _context.SaveChanges();
            return Ok(rDLab_MettlerToledoNEWClassicMF);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_MettlerToledoNEWClassicMF> payload)
        {
            RDLab_MettlerToledoNEWClassicMF rDLab_MettlerToledoNEWClassicMF = payload.value;
            _context.RDLab_MettlerToledoNEWClassicMF.Update(rDLab_MettlerToledoNEWClassicMF);
            _context.SaveChanges();
            return Ok(rDLab_MettlerToledoNEWClassicMF);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_MettlerToledoNEWClassicMF> payload)
        {
            RDLab_MettlerToledoNEWClassicMF rDLab_MettlerToledoNEWClassicMF = _context.RDLab_MettlerToledoNEWClassicMF
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_MettlerToledoNEWClassicMF.Remove(rDLab_MettlerToledoNEWClassicMF);
            _context.SaveChanges();
            return Ok(rDLab_MettlerToledoNEWClassicMF);

        }
    }
}