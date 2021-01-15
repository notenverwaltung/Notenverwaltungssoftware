using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class StudentsController : IStudentsController
    {
        private readonly DatabaseContext _context;

        public StudentsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Student> DeleteStudent(long id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return null;
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<Student> GetStudent(long id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return null;
            }

            return student;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task PutStudent(long id, Student student)
        {
            if (id != student.Id)
            {
                return;
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return;
                }
                else
                {
                    throw;
                }
            }

            return;
        }

        private bool StudentExists(long id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}