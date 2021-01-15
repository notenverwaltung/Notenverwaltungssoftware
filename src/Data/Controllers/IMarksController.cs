using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface IMarksController
    {
        Task<Mark> DeleteMark(long id);

        Task<Mark> GetMark(long id);

        Task<IEnumerable<Mark>> GetMarks();

        Task<Mark> PostMark(Mark mark);

        Task PutMark(long id, Mark mark);
    }
}