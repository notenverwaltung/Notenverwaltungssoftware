using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class LessonsController : ILessonsController
    {
        private readonly DatabaseContext _context;

        public LessonsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Lesson> DeleteLesson(long id)
        {
            var lesson = await _context.Lessons.FindAsync(id);
            if (lesson == null)
            {
                return null;
            }

            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();

            return lesson;
        }

        public async Task<Lesson> GetLesson(long id)
        {
            var lesson = await _context.Lessons.FindAsync(id);

            if (lesson == null)
            {
                return null;
            }

            return lesson;
        }

        public async Task<IEnumerable<Lesson>> GetLessons()
        {
            return await _context.Lessons.ToListAsync();
        }

        public async Task<Lesson> PostLesson(Lesson lesson)
        {
            _context.Lessons.Add(lesson);
            await _context.SaveChangesAsync();

            return lesson;
        }

        public async Task PutLesson(long id, Lesson lesson)
        {
            if (id != lesson.Id)
            {
                return;
            }

            _context.Entry(lesson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonExists(id))
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

        private bool LessonExists(long id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }
    }
}