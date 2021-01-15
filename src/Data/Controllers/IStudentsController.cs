using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface IStudentsController
    {
        Task<Student> DeleteStudent(long id);

        Task<Student> GetStudent(long id);

        Task<IEnumerable<Student>> GetStudents();

        Task<Student> PostStudent(Student student);

        Task PutStudent(long id, Student student);
    }
}