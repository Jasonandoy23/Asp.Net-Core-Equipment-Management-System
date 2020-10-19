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
    [Route("api/ONTSeqLab_Centrifuge5810R")]
    public class ONTSeqLab_Centrifuge5810RController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_Centrifuge5810RController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_Centrifuge5810R
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_Centrifuge5810R()
        {
            List<ONTSeqLab_Centrifuge5810R> Items = await _context.ONTSeqLab_Centrifuge5810R.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_Centrifuge5810R> payload)
        {
            ONTSeqLab_Centrifuge5810R oNTSeqLab_Centrifuge5810R = payload.value;
            _context.ONTSeqLab_Centrifuge5810R.Add(oNTSeqLab_Centrifuge5810R);
            _context.SaveChanges();
            return Ok(oNTSeqLab_Centrifuge5810R);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_Centrifuge5810R> payload)
        {
            ONTSeqLab_Centrifuge5810R oNTSeqLab_Centrifuge5810R = payload.value;
            _context.ONTSeqLab_Centrifuge5810R.Update(oNTSeqLab_Centrifuge5810R);
            _context.SaveChanges();
            return Ok(oNTSeqLab_Centrifuge5810R);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_Centrifuge5810R> payload)
        {
            ONTSeqLab_Centrifuge5810R oNTSeqLab_Centrifuge5810R = _context.ONTSeqLab_Centrifuge5810R
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_Centrifuge5810R.Remove(oNTSeqLab_Centrifuge5810R);
            _context.SaveChanges();
            return Ok(oNTSeqLab_Centrifuge5810R);

        }
    }
}