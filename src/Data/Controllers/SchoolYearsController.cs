using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class SchoolYearsController : ISchoolYearsController
    {
        private readonly DatabaseContext _context;

        public SchoolYearsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<SchoolYear> DeleteSchoolYear(long id)
        {
            var schoolYear = await _context.SchoolYears.FindAsync(id);
            if (schoolYear == null)
            {
                return null;
            }

            _context.SchoolYears.Remove(schoolYear);
            await _context.SaveChangesAsync();

            return schoolYear;
        }

        public async Task<SchoolYear> GetSchoolYear(long id)
        {
            var schoolYear = await _context.SchoolYears.FindAsync(id);

            if (schoolYear == null)
            {
                return null;
            }

            return schoolYear;
        }

        public async Task<IEnumerable<SchoolYear>> GetSchoolYears()
        {
            return await _context.SchoolYears.ToListAsync();
        }

        public async Task<SchoolYear> PostSchoolYear(SchoolYear schoolYear)
        {
            _context.SchoolYears.Add(schoolYear);
            await _context.SaveChangesAsync();

            return schoolYear;
        }

        public async Task PutSchoolYear(long id, SchoolYear schoolYear)
        {
            if (id != schoolYear.Id)
            {
                return;
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
                    return;
                }
                else
                {
                    throw;
                }
            }

            return;
        }

        private bool SchoolYearExists(long id)
        {
            return _context.SchoolYears.Any(e => e.Id == id);
        }
    }
}