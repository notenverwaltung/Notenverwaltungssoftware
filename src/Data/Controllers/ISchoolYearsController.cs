using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ISchoolYearsController
    {
        Task<SchoolYear> DeleteSchoolYear(long id);

        Task<SchoolYear> GetSchoolYear(long id);

        Task<IEnumerable<SchoolYear>> GetSchoolYears();

        Task<SchoolYear> PostSchoolYear(SchoolYear schoolYear);

        Task PutSchoolYear(long id, SchoolYear schoolYear);
    }
}