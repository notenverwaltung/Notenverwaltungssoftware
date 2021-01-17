using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class ClassesController : IClassesController
    {
        private readonly DatabaseContext _context;

        public ClassesController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Class> DeleteClass(Guid id)
        {
            var @class = await _context.Classes.FindAsync(id);
            if (@class == null)
            {
                return null;
            }

            _context.Classes.Remove(@class);
            await _context.SaveChangesAsync();

            return @class;
        }

        public async Task<Class> GetClass(Guid id)
        {
            var @class = await _context.Classes.FindAsync(id);

            if (@class == null)
            {
                return null;
            }

            return @class;
        }

        public async Task<IEnumerable<Class>> GetClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        public async Task<Class> PostClass(Class @class)
        {
            _context.Classes.Add(@class);
            await _context.SaveChangesAsync();

            return @class;
        }

        public async Task PutClass(Guid id, Class @class)
        {
            if (id != @class.Id)
            {
                return;
            }

            _context.Entry(@class).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                if (!ClassExists(id))
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

        private bool ClassExists(Guid id)
        {
            return _context.Classes.Any(e => e.Id == id);
        }
    }
}