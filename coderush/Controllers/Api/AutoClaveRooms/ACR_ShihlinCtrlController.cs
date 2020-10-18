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
    [Route("api/ACR_ShihlinCtrl")]
    public class ACR_ShihlinCtrlController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ACR_ShihlinCtrlController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ACR_ShihlinCtrl
        [HttpGet]
        public async Task<IActionResult> GetACR_ShihlinCtrl()
        {
            List<ACR_ShihlinCtrl> Items = await _context.ACR_ShihlinCtrl.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ACR_ShihlinCtrl> payload)
        {
            ACR_ShihlinCtrl ACR_ShihlinCtrl = payload.value;
            _context.ACR_ShihlinCtrl.Add(ACR_ShihlinCtrl);
            _context.SaveChanges();
            return Ok(ACR_ShihlinCtrl);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ACR_ShihlinCtrl> payload)
        {
            ACR_ShihlinCtrl ACR_ShihlinCtrl = payload.value;
            _context.ACR_ShihlinCtrl.Update(ACR_ShihlinCtrl);
            _context.SaveChanges();
            return Ok(ACR_ShihlinCtrl);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ACR_ShihlinCtrl> payload)
        {
            ACR_ShihlinCtrl ACR_ShihlinCtrl = _context.ACR_ShihlinCtrl
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ACR_ShihlinCtrl.Remove(ACR_ShihlinCtrl);
            _context.SaveChanges();
            return Ok(ACR_ShihlinCtrl);

        }
    }
}