using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ILessonsController
    {
        Task<Lesson> DeleteLesson(long id);

        Task<Lesson> GetLesson(long id);

        Task<IEnumerable<Lesson>> GetLessons();

        Task<Lesson> PostLesson(Lesson lesson);

        Task PutLesson(long id, Lesson lesson);
    }
}