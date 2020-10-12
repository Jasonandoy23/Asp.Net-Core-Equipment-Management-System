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
    [Route("api/Suppliers")]
    public class SuppliersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuppliersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Suppliers
        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            List<Suppliers> Items = await _context.Suppliers.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Suppliers> payload)
        {
            Suppliers suppliers = payload.value;
            _context.Suppliers.Add(suppliers);
            _context.SaveChanges();
            return Ok(suppliers);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Suppliers> payload)
        {
            Suppliers suppliers = payload.value;
            _context.Suppliers.Update(suppliers);
            _context.SaveChanges();
            return Ok(suppliers);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Suppliers> payload)
        {
            Suppliers suppliers = _context.Suppliers
                .Where(x => x.Suppliers_id == (long)payload.key)
                .FirstOrDefault();
            _context.Suppliers.Remove(suppliers);
            _context.SaveChanges();
            return Ok(suppliers);

        }
    }
}