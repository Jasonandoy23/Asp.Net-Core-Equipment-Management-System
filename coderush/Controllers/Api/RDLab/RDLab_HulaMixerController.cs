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
    [Route("api/RDLab_HulaMixer")]
    public class RDLab_HulaMixerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_HulaMixerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_HulaMixer
        [HttpGet]
        public async Task<IActionResult> GetRDLab_HulaMixer()
        {
            List<RDLab_HulaMixer> Items = await _context.RDLab_HulaMixer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_HulaMixer> payload)
        {
            RDLab_HulaMixer rDLab_HulaMixer = payload.value;
            _context.RDLab_HulaMixer.Add(rDLab_HulaMixer);
            _context.SaveChanges();
            return Ok(rDLab_HulaMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_HulaMixer> payload)
        {
            RDLab_HulaMixer rDLab_HulaMixer = payload.value;
            _context.RDLab_HulaMixer.Update(rDLab_HulaMixer);
            _context.SaveChanges();
            return Ok(rDLab_HulaMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_HulaMixer> payload)
        {
            RDLab_HulaMixer rDLab_HulaMixer = _context.RDLab_HulaMixer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_HulaMixer.Remove(rDLab_HulaMixer);
            _context.SaveChanges();
            return Ok(rDLab_HulaMixer);

        }
    }
}