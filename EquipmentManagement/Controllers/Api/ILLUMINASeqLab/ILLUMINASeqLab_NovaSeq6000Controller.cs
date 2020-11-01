using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using EquipmentManagement.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace EquipmentManagement.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/ILLUMINASeqLab_NovaSeq6000")]
    public class ILLUMINASeqLab_NovaSeq6000Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public ILLUMINASeqLab_NovaSeq6000Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ILLUMINASeqLab_NovaSeq6000
        [HttpGet]
        public async Task<IActionResult> GetILLUMINASeqLab_NovaSeq6000()
        {
            List<ILLUMINASeqLab_NovaSeq6000> Items = await _context.ILLUMINASeqLab_NovaSeq6000.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ILLUMINASeqLab_NovaSeq6000> payload)
        {
            ILLUMINASeqLab_NovaSeq6000 iILLUMINASeqLab_NovaSeq6000 = payload.value;
            _context.ILLUMINASeqLab_NovaSeq6000.Add(iILLUMINASeqLab_NovaSeq6000);
            _context.SaveChanges();
            return Ok(iILLUMINASeqLab_NovaSeq6000);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ILLUMINASeqLab_NovaSeq6000> payload)
        {
            ILLUMINASeqLab_NovaSeq6000 iILLUMINASeqLab_NovaSeq6000 = payload.value;
            _context.ILLUMINASeqLab_NovaSeq6000.Update(iILLUMINASeqLab_NovaSeq6000);
            _context.SaveChanges();
            return Ok(iILLUMINASeqLab_NovaSeq6000);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ILLUMINASeqLab_NovaSeq6000> payload)
        {
            ILLUMINASeqLab_NovaSeq6000 iILLUMINASeqLab_NovaSeq6000 = _context.ILLUMINASeqLab_NovaSeq6000
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ILLUMINASeqLab_NovaSeq6000.Remove(iILLUMINASeqLab_NovaSeq6000);
            _context.SaveChanges();
            return Ok(iILLUMINASeqLab_NovaSeq6000);

        }
    }
}