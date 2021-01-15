using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Fach.
    /// </summary>
    /// <seealso cref="Data.Models.BaseModel" />
    public class Subject : BaseModel
    {
        /// <summary>
        /// Gets or sets the lessons.
        /// </summary>
        /// <value>The lessons.</value>
        public ICollection<Lesson> Lessons { get; set; }

        /// <summary>
        /// Gets or sets the markings.
        /// </summary>
        /// <value>The markings.</value>
        public ICollection<Mark> Marks { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the teacher subjects.
        /// </summary>
        /// <value>The teacher subjects.</value>
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}