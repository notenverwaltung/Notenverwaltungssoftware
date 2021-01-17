using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class SubjectsController : ISubjectsController
    {
        private readonly DatabaseContext _context;

        public SubjectsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Subject> DeleteSubject(Guid id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject == null)
            {
                return null;
            }

            _context.Subjects.Remove(subject);
            await _context.SaveChangesAsync();

            return subject;
        }

        public async Task<Subject> GetSubject(Guid id)
        {
            var subject = await _context.Subjects.FindAsync(id);

            if (subject == null)
            {
                return null;
            }

            return subject;
        }

        public async Task<IEnumerable<Subject>> GetSubjects()
        {
            return await _context.Subjects.ToListAsync();
        }

        public async Task<Subject> PostSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();

            return subject;
        }

        public async Task PutSubject(Guid id, Subject subject)
        {
            if (id != subject.Id)
            {
                return;
            }

            _context.Entry(subject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectExists(id))
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

        private bool SubjectExists(Guid id)
        {
            return _context.Subjects.Any(e => e.Id == id);
        }
    }
}