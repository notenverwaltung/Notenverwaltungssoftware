using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface IClassesController
    {
        Task<Class> DeleteClass(long id);

        Task<Class> GetClass(long id);

        Task<IEnumerable<Class>> GetClasses();

        Task<Class> PostClass(Class @class);

        Task PutClass(long id, Class @class);
    }
}