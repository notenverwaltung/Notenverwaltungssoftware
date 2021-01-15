using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class MarksController : IMarksController
    {
        private readonly DatabaseContext _context;

        public MarksController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Mark> DeleteMark(long id)
        {
            var mark = await _context.Marks.FindAsync(id);
            if (mark == null)
            {
                return null;
            }

            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();

            return mark;
        }

        public async Task<Mark> GetMark(long id)
        {
            var mark = await _context.Marks.FindAsync(id);

            if (mark == null)
            {
                return null;
            }

            return mark;
        }

        public async Task<IEnumerable<Mark>> GetMarks()
        {
            return await _context.Marks.ToListAsync();
        }

        public async Task<Mark> PostMark(Mark mark)
        {
            _context.Marks.Add(mark);
            await _context.SaveChangesAsync();

            return mark;
        }

        public async Task PutMark(long id, Mark mark)
        {
            if (id != mark.Id)
            {
                return;
            }

            _context.Entry(mark).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarkExists(id))
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

        private bool MarkExists(long id)
        {
            return _context.Marks.Any(e => e.Id == id);
        }
    }
}