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
    public class LectureshipsController : ControllerBase
    {
        private readonly WebApiDbContext _context;

        public LectureshipsController(WebApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Lectureships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lectureship>>> GetLectureship()
        {
            return await _context.Lectureship.ToListAsync();
        }

        // GET: api/Lectureships/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lectureship>> GetLectureship(Guid id)
        {
            var lectureship = await _context.Lectureship.FindAsync(id);

            if (lectureship == null)
            {
                return NotFound();
            }

            return lectureship;
        }

        // PUT: api/Lectureships/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLectureship(Guid id, Lectureship lectureship)
        {
            if (id != lectureship.Id)
            {
                return BadRequest();
            }

            _context.Entry(lectureship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LectureshipExists(id))
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

        // POST: api/Lectureships
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Lectureship>> PostLectureship(Lectureship lectureship)
        {
            _context.Lectureship.Add(lectureship);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLectureship", new { id = lectureship.Id }, lectureship);
        }

        // DELETE: api/Lectureships/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lectureship>> DeleteLectureship(Guid id)
        {
            var lectureship = await _context.Lectureship.FindAsync(id);
            if (lectureship == null)
            {
                return NotFound();
            }

            _context.Lectureship.Remove(lectureship);
            await _context.SaveChangesAsync();

            return lectureship;
        }

        private bool LectureshipExists(Guid id)
        {
            return _context.Lectureship.Any(e => e.Id == id);
        }
    }
}
