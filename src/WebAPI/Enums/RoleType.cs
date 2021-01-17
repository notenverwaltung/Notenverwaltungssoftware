using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Enums
{
    /// <summary>
    /// Job.
    /// </summary>
    public enum RoleType
    {
        /// <summary>
        /// Fachlehrer.
        /// </summary>
        Teacher = 0,

        /// <summary>
        /// Klassenlehrer.
        /// </summary>
        ClassTeacher = 1,

        /// <summary>
        /// Schulleiter.
        /// </summary>
        Principal = 2,

        /// <summary>
        /// Verwaltungslehrer.
        /// </summary>
        AdminTeacher = 3,

        /// <summary>
        /// The admin
        /// </summary>
        Admin = 4,
    }
}