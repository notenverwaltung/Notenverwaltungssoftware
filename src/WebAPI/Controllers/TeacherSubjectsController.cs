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
    public class TeacherSubjectsController : ControllerBase
    {
        private readonly WebApiDbContext _context;

        public TeacherSubjectsController(WebApiDbContext context)
        {
            _context = context;
        }

        // GET: api/TeacherSubjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherSubject>>> GetTeacherSubjects()
        {
            return await _context.TeacherSubjects.ToListAsync();
        }

        // GET: api/TeacherSubjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherSubject>> GetTeacherSubject(Guid id)
        {
            var teacherSubject = await _context.TeacherSubjects.FindAsync(id);

            if (teacherSubject == null)
            {
                return NotFound();
            }

            return teacherSubject;
        }

        // PUT: api/TeacherSubjects/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacherSubject(Guid id, TeacherSubject teacherSubject)
        {
            if (id != teacherSubject.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacherSubject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherSubjectExists(id))
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

        // POST: api/TeacherSubjects
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TeacherSubject>> PostTeacherSubject(TeacherSubject teacherSubject)
        {
            _context.TeacherSubjects.Add(teacherSubject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacherSubject", new { id = teacherSubject.Id }, teacherSubject);
        }

        // DELETE: api/TeacherSubjects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeacherSubject>> DeleteTeacherSubject(Guid id)
        {
            var teacherSubject = await _context.TeacherSubjects.FindAsync(id);
            if (teacherSubject == null)
            {
                return NotFound();
            }

            _context.TeacherSubjects.Remove(teacherSubject);
            await _context.SaveChangesAsync();

            return teacherSubject;
        }

        private bool TeacherSubjectExists(Guid id)
        {
            return _context.TeacherSubjects.Any(e => e.Id == id);
        }
    }
}
