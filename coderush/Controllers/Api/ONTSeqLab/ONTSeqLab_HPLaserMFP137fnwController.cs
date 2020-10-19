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
    [Route("api/ONTSeqLab_HPLaserMFP137fnw")]
    public class ONTSeqLab_HPLaserMFP137fnwController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_HPLaserMFP137fnwController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_HPLaserMFP137fnw
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_HPLaserMFP137fnw()
        {
            List<ONTSeqLab_HPLaserMFP137fnw> Items = await _context.ONTSeqLab_HPLaserMFP137fnw.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_HPLaserMFP137fnw> payload)
        {
            ONTSeqLab_HPLaserMFP137fnw oNTSeqLab_HPLaserMFP137fnw = payload.value;
            _context.ONTSeqLab_HPLaserMFP137fnw.Add(oNTSeqLab_HPLaserMFP137fnw);
            _context.SaveChanges();
            return Ok(oNTSeqLab_HPLaserMFP137fnw);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_HPLaserMFP137fnw> payload)
        {
            ONTSeqLab_HPLaserMFP137fnw oNTSeqLab_HPLaserMFP137fnw = payload.value;
            _context.ONTSeqLab_HPLaserMFP137fnw.Update(oNTSeqLab_HPLaserMFP137fnw);
            _context.SaveChanges();
            return Ok(oNTSeqLab_HPLaserMFP137fnw);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_HPLaserMFP137fnw> payload)
        {
            ONTSeqLab_HPLaserMFP137fnw oNTSeqLab_HPLaserMFP137fnw = _context.ONTSeqLab_HPLaserMFP137fnw
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_HPLaserMFP137fnw.Remove(oNTSeqLab_HPLaserMFP137fnw);
            _context.SaveChanges();
            return Ok(oNTSeqLab_HPLaserMFP137fnw);

        }
    }
}