using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ISubjectsController
    {
        Task<Subject> DeleteSubject(Guid id);

        Task<Subject> GetSubject(Guid id);

        Task<IEnumerable<Subject>> GetSubjects();

        Task<Subject> PostSubject(Subject subject);

        Task PutSubject(Guid id, Subject subject);
    }
}