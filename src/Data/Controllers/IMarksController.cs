using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface IMarksController
    {
        Task<Mark> DeleteMark(Guid id);

        Task<Mark> GetMark(Guid id);

        Task<IEnumerable<Mark>> GetMarks();

        Task<Mark> PostMark(Mark mark);

        Task PutMark(Guid id, Mark mark);
    }
}