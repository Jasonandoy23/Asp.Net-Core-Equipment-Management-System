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
    [Route("api/ONTSeqLab_IndDehumidifierClimatePlus")]
    public class ONTSeqLab_IndDehumidifierClimatePlusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ONTSeqLab_IndDehumidifierClimatePlusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ONTSeqLab_IndDehumidifierClimatePlus
        [HttpGet]
        public async Task<IActionResult> GetONTSeqLab_IndDehumidifierClimatePlus()
        {
            List<ONTSeqLab_IndDehumidifierClimatePlus> Items = await _context.ONTSeqLab_IndDehumidifierClimatePlus.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ONTSeqLab_IndDehumidifierClimatePlus> payload)
        {
            ONTSeqLab_IndDehumidifierClimatePlus oNTSeqLab_IndDehumidifierClimatePlus = payload.value;
            _context.ONTSeqLab_IndDehumidifierClimatePlus.Add(oNTSeqLab_IndDehumidifierClimatePlus);
            _context.SaveChanges();
            return Ok(oNTSeqLab_IndDehumidifierClimatePlus);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ONTSeqLab_IndDehumidifierClimatePlus> payload)
        {
            ONTSeqLab_IndDehumidifierClimatePlus oNTSeqLab_IndDehumidifierClimatePlus = payload.value;
            _context.ONTSeqLab_IndDehumidifierClimatePlus.Update(oNTSeqLab_IndDehumidifierClimatePlus);
            _context.SaveChanges();
            return Ok(oNTSeqLab_IndDehumidifierClimatePlus);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ONTSeqLab_IndDehumidifierClimatePlus> payload)
        {
            ONTSeqLab_IndDehumidifierClimatePlus oNTSeqLab_IndDehumidifierClimatePlus = _context.ONTSeqLab_IndDehumidifierClimatePlus
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ONTSeqLab_IndDehumidifierClimatePlus.Remove(oNTSeqLab_IndDehumidifierClimatePlus);
            _context.SaveChanges();
            return Ok(oNTSeqLab_IndDehumidifierClimatePlus);

        }
    }
}