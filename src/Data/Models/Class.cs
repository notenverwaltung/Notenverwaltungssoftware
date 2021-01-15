using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Klasse.
    /// </summary>
    public class Class : BaseModel
    {
        /// <summary>
        /// Gets or sets the appendix.
        /// </summary>
        /// <value>The appendix.</value>
        public string Appendix { get; set; }

        /// <summary>
        /// Gets or sets the class teacher.
        /// </summary>
        /// <value>The class teacher.</value>
        public Teacher ClassTeacher { get; set; }

        /// <summary>
        /// Gets or sets the classeacher identifier.
        /// </summary>
        /// <value>The classeacher identifier.</value>
        public long ClassTeacherId { get; set; }

        /// <summary>
        /// Gets or sets the grade.
        /// </summary>
        /// <value>The grade.</value>
        public byte Grade { get; set; }

        /// <summary>
        /// Gets or sets the lessons.
        /// </summary>
        /// <value>The lessons.</value>
        public ICollection<Lesson> Lessons { get; set; }

        /// <summary>
        /// Gets or sets the students.
        /// </summary>
        /// <value>The students.</value>
        public ICollection<Student> Students { get; set; }
    }
}