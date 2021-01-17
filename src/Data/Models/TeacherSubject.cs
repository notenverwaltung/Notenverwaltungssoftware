using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// TeacherSubject.
    /// </summary>
    /// <seealso cref="Data.Models.BaseModel" />
    public class TeacherSubject : BaseModel
    {
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public Subject Subject { get; set; }

        /// <summary>
        /// Gets or sets the subject identifier.
        /// </summary>
        /// <value>The subject identifier.</value>
        public Guid SubjectId { get; set; }

        /// <summary>
        /// Gets or sets the teacher.
        /// </summary>
        /// <value>The teacher.</value>
        public Teacher Teacher { get; set; }

        /// <summary>
        /// Gets or sets the teacher identifier.
        /// </summary>
        /// <value>The teacher identifier.</value>
        public Guid TeacherId { get; set; }
    }
}