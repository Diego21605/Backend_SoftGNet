using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend_SoftGNet.Data;
using Backend_SoftGNet.Models;
using Microsoft.AspNetCore.Authorization;

namespace Backend_SoftGNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class SchedulesController : ControllerBase
    {
        private readonly dataContext _context;

        public SchedulesController(dataContext context)
        {
            _context = context;
        }

        // GET: api/Schedules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Schedules>>> GetSchedules()
        {
            return await _context.Schedules.ToListAsync();
        }

        // GET: api/Schedules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Schedules>> GetSchedules(int id)
        {
            var schedules = await _context.Schedules.FindAsync(id);

            if (schedules == null)
            {
                return NotFound();
            }

            return schedules;
        }

        [HttpGet("getSchedulers")]
        public ActionResult GetSchedulers()
        {
            var schedulers = from s in _context.Set<Schedules>()
                             join r in _context.Set<Routes>() on s.Route_Id equals r.Id
                             select new
                             {
                                 s.Id,
                                 Route_Id = r.Id,
                                 Route = r.Description,
                                 s.Week_Num,
                                 s.From,
                                 s.To,
                                 s.Active
                             };

            return Ok(schedulers);
        }

        // PUT: api/Schedules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchedules(int id, Schedules schedules)
        {
            if (id != schedules.Id)
            {
                return BadRequest();
            }

            _context.Entry(schedules).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchedulesExists(id))
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

        // POST: api/Schedules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Schedules>> PostSchedules(Schedules schedules)
        {
            _context.Schedules.Add(schedules);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchedules", new { id = schedules.Id }, schedules);
        }

        // DELETE: api/Schedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchedules(int id)
        {
            var schedules = await _context.Schedules.FindAsync(id);
            if (schedules == null)
            {
                return NotFound();
            }

            _context.Schedules.Remove(schedules);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SchedulesExists(int id)
        {
            return _context.Schedules.Any(e => e.Id == id);
        }
    }
}
