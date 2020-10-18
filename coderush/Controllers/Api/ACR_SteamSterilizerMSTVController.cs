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
    [Route("api/ACR_SteamSterilizerMSTV")]
    public class ACR_SteamSterilizerMSTVController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ACR_SteamSterilizerMSTVController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ACR_SteamSterilizerMSTV
        [HttpGet]
        public async Task<IActionResult> GetACR_SteamSterilizerMSTV()
        {
            List<ACR_SteamSterilizerMSTV> Items = await _context.ACR_SteamSterilizerMSTV.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ACR_SteamSterilizerMSTV> payload)
        {
            ACR_SteamSterilizerMSTV aCR_SteamSterilizerMSTV = payload.value;
            _context.ACR_SteamSterilizerMSTV.Add(aCR_SteamSterilizerMSTV);
            _context.SaveChanges();
            return Ok(aCR_SteamSterilizerMSTV);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ACR_SteamSterilizerMSTV> payload)
        {
            ACR_SteamSterilizerMSTV aCR_SteamSterilizerMSTV = payload.value;
            _context.ACR_SteamSterilizerMSTV.Update(aCR_SteamSterilizerMSTV);
            _context.SaveChanges();
            return Ok(aCR_SteamSterilizerMSTV);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ACR_SteamSterilizerMSTV> payload)
        {
            ACR_SteamSterilizerMSTV aCR_SteamSterilizerMSTV = _context.ACR_SteamSterilizerMSTV
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ACR_SteamSterilizerMSTV.Remove(aCR_SteamSterilizerMSTV);
            _context.SaveChanges();
            return Ok(aCR_SteamSterilizerMSTV);

        }
    }
}