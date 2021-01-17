using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class LectureshipController : ILectureshipController
    {
        private readonly DatabaseContext _context;

        public LectureshipController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Lectureship> DeleteLectureship(Guid id)
        {
            var Lectureship = await _context.Lectureship.FindAsync(id);
            if (Lectureship == null)
            {
                return null;
            }

            _context.Lectureship.Remove(Lectureship);
            await _context.SaveChangesAsync();

            return Lectureship;
        }

        public async Task<Lectureship> GetLectureship(Guid id)
        {
            var Lectureship = await _context.Lectureship.FindAsync(id);

            if (Lectureship == null)
            {
                return null;
            }

            return Lectureship;
        }

        public async Task<IEnumerable<Lectureship>> GetLectureships()
        {
            return await _context.Lectureship.ToListAsync();
        }

        public async Task<Lectureship> PostLectureship(Lectureship Lectureship)
        {
            _context.Lectureship.Add(Lectureship);
            await _context.SaveChangesAsync();

            return Lectureship;
        }

        public async Task PutLectureship(Guid id, Lectureship Lectureship)
        {
            if (id != Lectureship.Id)
            {
                return;
            }

            _context.Entry(Lectureship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LectureshipExists(id))
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

        private bool LectureshipExists(Guid id)
        {
            return _context.Lectureship.Any(e => e.Id == id);
        }
    }
}