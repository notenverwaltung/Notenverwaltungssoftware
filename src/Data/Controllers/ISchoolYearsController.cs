using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ISchoolYearsController
    {
        Task<SchoolYear> DeleteSchoolYear(Guid id);

        Task<SchoolYear> GetSchoolYear(Guid id);

        Task<IEnumerable<SchoolYear>> GetSchoolYears();

        Task<SchoolYear> PostSchoolYear(SchoolYear schoolYear);

        Task PutSchoolYear(Guid id, SchoolYear schoolYear);
    }
}