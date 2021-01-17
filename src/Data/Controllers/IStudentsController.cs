using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface IStudentsController
    {
        Task<Student> DeleteStudent(Guid id);

        Task<Student> GetStudent(Guid id);

        Task<IEnumerable<Student>> GetStudents();

        Task<Student> PostStudent(Student student);

        Task PutStudent(Guid id, Student student);
    }
}