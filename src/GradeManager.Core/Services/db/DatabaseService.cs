using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GradeManager.Core.Services
{
    public class DatabaseService : IDatabaseService
    {
        private DatabaseContext _context;

        public DatabaseService(DatabaseContext context)
        {
            _context = context;
        }

        public GradeModel AddGrade(string name, string url)
        {
            var grade = _context.Grades.Add(new GradeModel { /*Name = name, Url = url*/ });
            _context.SaveChanges();

            return grade.Entity;
        }

        public List<GradeModel> GetAllGrades()
        {
            //var query = from b in _context.Grades
            //            orderby b.Id
            //            select b;

            //return query.ToList();
            return null;
        }

        public async Task<List<GradeModel>> GetAllGradesAsync()
        {
            //var query = from b in _context.Grades
            //            orderby b.Id
            //            select b;

            //return await query.ToListAsync();
            return null;
        }

        public bool SetGrade(GradeModel grade)
        {
            return false;
        }
    }
}