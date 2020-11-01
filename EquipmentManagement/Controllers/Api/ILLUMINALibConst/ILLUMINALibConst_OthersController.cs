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
    [Route("api/ILLUMINALibConst_Others")]
    public class ILLUMINALibConst_OthersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ILLUMINALibConst_OthersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ILLUMINALibConst_Others
        [HttpGet]
        public async Task<IActionResult> GetILLUMINALibConst_Others()
        {
            List<ILLUMINALibConst_Others> Items = await _context.ILLUMINALibConst_Others.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<ILLUMINALibConst_Others> payload)
        {
            ILLUMINALibConst_Others iLLUMINALibConst_Others = payload.value;
            _context.ILLUMINALibConst_Others.Add(iLLUMINALibConst_Others);
            _context.SaveChanges();
            return Ok(iLLUMINALibConst_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<ILLUMINALibConst_Others> payload)
        {
            ILLUMINALibConst_Others iLLUMINALibConst_Others = payload.value;
            _context.ILLUMINALibConst_Others.Update(iLLUMINALibConst_Others);
            _context.SaveChanges();
            return Ok(iLLUMINALibConst_Others);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<ILLUMINALibConst_Others> payload)
        {
            ILLUMINALibConst_Others iLLUMINALibConst_Others = _context.ILLUMINALibConst_Others
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.ILLUMINALibConst_Others.Remove(iLLUMINALibConst_Others);
            _context.SaveChanges();
            return Ok(iLLUMINALibConst_Others);

        }
    }
}