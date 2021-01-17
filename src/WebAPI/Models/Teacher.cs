using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Enums;

namespace WebAPI.Models
{
    /// <summary>
    /// Mitarbeiter.
    /// </summary>
    /// <seealso cref="WebAPI.Models.Person" />
    public class Teacher : Person
    {
        /// <summary>
        /// Gets or sets the abbreviation.
        /// </summary>
        /// <value>The abbreviation.</value>
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        /// <value>The class.</value>
        public Class Class { get; set; }

        /// <summary>
        /// Gets or sets the lessons.
        /// </summary>
        /// <value>The lessons.</value>
        public ICollection<Lectureship> Lectureships { get; set; }

        /// <summary>
        /// Gets or sets the teacher subjects.
        /// </summary>
        /// <value>The teacher subjects.</value>
        public ICollection<Mark> Marks { get; set; }

        /// <summary>
        /// Gets or sets the teacher subjects.
        /// </summary>
        /// <value>The teacher subjects.</value>
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
    }
}