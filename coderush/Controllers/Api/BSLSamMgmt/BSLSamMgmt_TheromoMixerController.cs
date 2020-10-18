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
    [Route("api/BSLSamMgmt_TheromoMixer")]
    public class BSLSamMgmt_TheromoMixerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BSLSamMgmt_TheromoMixerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BSLSamMgmt_TheromoMixer
        [HttpGet]
        public async Task<IActionResult> GetBSLSamMgmt_TheromoMixer()
        {
            List<BSLSamMgmt_TheromoMixer> Items = await _context.BSLSamMgmt_TheromoMixer.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BSLSamMgmt_TheromoMixer> payload)
        {
            BSLSamMgmt_TheromoMixer bSLSamMgmt_TheromoMixer = payload.value;
            _context.BSLSamMgmt_TheromoMixer.Add(bSLSamMgmt_TheromoMixer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_TheromoMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BSLSamMgmt_TheromoMixer> payload)
        {
            BSLSamMgmt_TheromoMixer bSLSamMgmt_TheromoMixer = payload.value;
            _context.BSLSamMgmt_TheromoMixer.Update(bSLSamMgmt_TheromoMixer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_TheromoMixer);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BSLSamMgmt_TheromoMixer> payload)
        {
            BSLSamMgmt_TheromoMixer bSLSamMgmt_TheromoMixer = _context.BSLSamMgmt_TheromoMixer
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.BSLSamMgmt_TheromoMixer.Remove(bSLSamMgmt_TheromoMixer);
            _context.SaveChanges();
            return Ok(bSLSamMgmt_TheromoMixer);

        }
    }
}