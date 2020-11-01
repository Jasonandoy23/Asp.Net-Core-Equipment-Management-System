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
    [Route("api/RDLab_NanodropOne")]
    public class RDLab_NanodropOneController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RDLab_NanodropOneController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RDLab_NanodropOne
        [HttpGet]
        public async Task<IActionResult> GetRDLab_NanodropOne()
        {
            List<RDLab_NanodropOne> Items = await _context.RDLab_NanodropOne.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<RDLab_NanodropOne> payload)
        {
            RDLab_NanodropOne rDLab_NanodropOne = payload.value;
            _context.RDLab_NanodropOne.Add(rDLab_NanodropOne);
            _context.SaveChanges();
            return Ok(rDLab_NanodropOne);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<RDLab_NanodropOne> payload)
        {
            RDLab_NanodropOne rDLab_NanodropOne = payload.value;
            _context.RDLab_NanodropOne.Update(rDLab_NanodropOne);
            _context.SaveChanges();
            return Ok(rDLab_NanodropOne);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<RDLab_NanodropOne> payload)
        {
            RDLab_NanodropOne rDLab_NanodropOne = _context.RDLab_NanodropOne
                .Where(x => x.LogId == (long)payload.key)
                .FirstOrDefault();
            _context.RDLab_NanodropOne.Remove(rDLab_NanodropOne);
            _context.SaveChanges();
            return Ok(rDLab_NanodropOne);

        }
    }
}