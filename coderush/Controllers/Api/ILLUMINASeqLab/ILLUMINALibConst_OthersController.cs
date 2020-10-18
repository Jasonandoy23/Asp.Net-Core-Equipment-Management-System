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
    [Route("api/ILLUMINASeqLab_Others")]
    public class ILLUMINASeqLab_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ILLUMINASeqLab_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ILLUMINASeqLab_Others
        [HttpGet]
        public async Task<IActionResult> GetILLUMINASeqLab_Others()
        {
            List<ILLUMINASeqLab_Others> Items = await _context.ILLUMINASeqLab_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ILLUMINASeqLab_Others> payload)
        {
            ILLUMINASeqLab_Others iLLUMINASeqLab_Others = payload.value;
            _context.ILLUMINASeqLab_Others.Add(iLLUMINASeqLab_Others);
            _context.SaveChanges();
            return Ok(iLLUMINASeqLab_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ILLUMINASeqLab_Others> payload)
        {
            ILLUMINASeqLab_Others iLLUMINASeqLab_Others = payload.value;
            _context.ILLUMINASeqLab_Others.Update(iLLUMINASeqLab_Others);
            _context.SaveChanges();
            return Ok(iLLUMINASeqLab_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ILLUMINASeqLab_Others> payload)
        {
            ILLUMINASeqLab_Others iLLUMINASeqLab_Others = _context.ILLUMINASeqLab_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ILLUMINASeqLab_Others.Remove(iLLUMINASeqLab_Others);
            _context.SaveChanges();
            return Ok(iLLUMINASeqLab_Others);

        }
    }
}