using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend_SoftGNet.Data;
using Backend_SoftGNet.Models;

namespace Backend_SoftGNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly dataContext _context;

        public DriversController(dataContext context)
        {
            _context = context;
        }

        // GET: api/Drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Drivers>>> GetDrivers()
        {
            return await _context.Drivers.ToListAsync();
        }

        // GET: api/Drivers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Drivers>> GetDrivers(int id)
        {
            var drivers = await _context.Drivers.FindAsync(id);

            if (drivers == null)
            {
                return NotFound();
            }

            return drivers;
        }

        // PUT: api/Drivers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrivers(int id, Drivers drivers)
        {
            if (id != drivers.Id)
            {
                return BadRequest();
            }

            _context.Entry(drivers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriversExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Drivers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Drivers>> PostDrivers(Drivers drivers)
        {
            _context.Drivers.Add(drivers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDrivers", new { id = drivers.Id }, drivers);
        }

        // DELETE: api/Drivers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrivers(int id)
        {
            var drivers = await _context.Drivers.FindAsync(id);
            if (drivers == null)
            {
                return NotFound();
            }

            _context.Drivers.Remove(drivers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DriversExists(int id)
        {
            return _context.Drivers.Any(e => e.Id == id);
        }
    }
}
