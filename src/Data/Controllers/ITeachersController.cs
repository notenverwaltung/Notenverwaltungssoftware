using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ITeachersController
    {
        Task<Teacher> DeleteTeacher(long id);

        Task<Teacher> GetTeacher(long id);

        Task<IEnumerable<Teacher>> GetTeachers();

        Task<Teacher> PostTeacher(Teacher teacher);

        Task PutTeacher(long id, Teacher teacher);
    }
}