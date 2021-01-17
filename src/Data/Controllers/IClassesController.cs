using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface IClassesController
    {
        Task<Class> DeleteClass(Guid id);

        Task<Class> GetClass(Guid id);

        Task<IEnumerable<Class>> GetClasses();

        Task<Class> PostClass(Class @class);

        Task PutClass(Guid id, Class @class);
    }
}