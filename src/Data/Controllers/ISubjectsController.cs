using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ISubjectsController
    {
        Task<Subject> DeleteSubject(long id);

        Task<Subject> GetSubject(long id);

        Task<IEnumerable<Subject>> GetSubjects();

        Task<Subject> PostSubject(Subject subject);

        Task PutSubject(long id, Subject subject);
    }
}