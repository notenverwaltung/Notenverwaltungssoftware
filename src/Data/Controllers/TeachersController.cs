using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class TeachersController : ITeachersController
    {
        private readonly DatabaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeachersController" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TeachersController(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<Teacher> DeleteTeacher(Guid id)
        {
            var teacher = await context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return null;
            }

            context.Teachers.Remove(teacher);
            await context.SaveChangesAsync();

            return teacher;
        }

        public async Task<Teacher> GetTeacher(Guid id)
        {
            var teacher = await context.Teachers.FindAsync(id);

            if (teacher == null)
            {
                return null;
            }

            return teacher;
        }

        public async Task<IEnumerable<Teacher>> GetTeachers()
        {
            return await context.Teachers.ToListAsync();
        }

        public async Task<Teacher> PostTeacher(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            await context.SaveChangesAsync();

            return teacher;
        }

        public async Task PutTeacher(Guid id, Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return;
            }

            context.Entry(teacher).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(id))
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

        private bool TeacherExists(Guid id)
        {
            return context.Teachers.Any(e => e.Id == id);
        }
    }
}