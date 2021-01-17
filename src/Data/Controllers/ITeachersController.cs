using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ITeachersController
    {
        Task<Teacher> DeleteTeacher(Guid id);

        Task<Teacher> GetTeacher(Guid id);

        Task<IEnumerable<Teacher>> GetTeachers();

        Task<Teacher> PostTeacher(Teacher teacher);

        Task PutTeacher(Guid id, Teacher teacher);
    }
}