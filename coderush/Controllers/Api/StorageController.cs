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
    [Route("api/Storage")]
    public class StorageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StorageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Storage
        [HttpGet]
        public async Task<IActionResult> GetStorage()
        {
            List<Storage> Items = await _context.Storage.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Storage> payload)
        {
            Storage storage = payload.value;
            _context.Storage.Add(storage);
            _context.SaveChanges();
            return Ok(storage);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Storage> payload)
        {
            Storage storage = payload.value;
            _context.Storage.Update(storage);
            _context.SaveChanges();
            return Ok(storage);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Storage> payload)
        {
            Storage storage = _context.Storage
                .Where(x => x.Storage_id == (long)payload.key)
                .FirstOrDefault();
            _context.Storage.Remove(storage);
            _context.SaveChanges();
            return Ok(storage);

        }
    }
}