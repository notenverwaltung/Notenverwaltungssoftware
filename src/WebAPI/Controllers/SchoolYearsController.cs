using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolYearsController : ControllerBase
    {
        private readonly WebApiDbContext _context;

        public SchoolYearsController(WebApiDbContext context)
        {
            _context = context;
        }

        // GET: api/SchoolYears
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchoolYear>>> GetSchoolYears()
        {
            return await _context.SchoolYears.ToListAsync();
        }

        // GET: api/SchoolYears/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolYear>> GetSchoolYear(Guid id)
        {
            var schoolYear = await _context.SchoolYears.FindAsync(id);

            if (schoolYear == null)
            {
                return NotFound();
            }

            return schoolYear;
        }

        // PUT: api/SchoolYears/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchoolYear(Guid id, SchoolYear schoolYear)
        {
            if (id != schoolYear.Id)
            {
                return BadRequest();
            }

            _context.Entry(schoolYear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchoolYearExists(id))
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

        // POST: api/SchoolYears
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SchoolYear>> PostSchoolYear(SchoolYear schoolYear)
        {
            _context.SchoolYears.Add(schoolYear);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchoolYear", new { id = schoolYear.Id }, schoolYear);
        }

        // DELETE: api/SchoolYears/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SchoolYear>> DeleteSchoolYear(Guid id)
        {
            var schoolYear = await _context.SchoolYears.FindAsync(id);
            if (schoolYear == null)
            {
                return NotFound();
            }

            _context.SchoolYears.Remove(schoolYear);
            await _context.SaveChangesAsync();

            return schoolYear;
        }

        private bool SchoolYearExists(Guid id)
        {
            return _context.SchoolYears.Any(e => e.Id == id);
        }
    }
}
