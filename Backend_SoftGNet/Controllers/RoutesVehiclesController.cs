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
    public class RoutesVehiclesController : ControllerBase
    {
        private readonly dataContext _context;

        public RoutesVehiclesController(dataContext context)
        {
            _context = context;
        }

        // GET: api/RoutesVehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Routes>>> GetRoute()
        {
            return await _context.Route.ToListAsync();
        }

        // GET: api/RoutesVehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Routes>> GetRoutes(int id)
        {
            var routes = await _context.Route.FindAsync(id);

            if (routes == null)
            {
                return NotFound();
            }

            return routes;
        }

        [HttpGet("getRoutes")]
        public ActionResult GetRoutes()
        {
            var routes = from r in _context.Set<Routes>()
                         join d in _context.Set<Drivers>() on r.Driver_Id equals d.Id
                         join v in _context.Set<Vehicles>() on r.Vehicle_Id equals v.Id
                         select new
                         {
                             r.Id,
                             r.Description,
                             Driver_Id = d.Id,
                             Driver = d.First_name + " " + d.Last_name,
                             Vehicle_Id = v.Id,
                             Vehicle = v.Description,
                             r.Active,
                         };

            return Ok(routes);
        }

        // PUT: api/RoutesVehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoutes(int id, Routes routes)
        {
            if (id != routes.Id)
            {
                return BadRequest();
            }

            _context.Entry(routes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoutesExists(id))
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

        // POST: api/RoutesVehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Routes>> PostRoutes(Routes routes)
        {
            _context.Route.Add(routes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoutes", new { id = routes.Id }, routes);
        }

        // DELETE: api/RoutesVehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoutes(int id)
        {
            var routes = await _context.Route.FindAsync(id);
            if (routes == null)
            {
                return NotFound();
            }

            _context.Route.Remove(routes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoutesExists(int id)
        {
            return _context.Route.Any(e => e.Id == id);
        }
    }
}
