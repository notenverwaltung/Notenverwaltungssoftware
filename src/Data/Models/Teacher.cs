using System.Collections.Generic;

namespace Data.Models
{
    /// <summary>
    /// Mitarbeiter.
    /// </summary>
    /// <seealso cref="Data.Models.Person" />
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
        public ICollection<Lesson> Lessons { get; set; }

        /// <summary>
        /// Gets or sets the markings.
        /// </summary>
        /// <value>The markings.</value>
        public ICollection<Mark> Marks { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the teacher subjects.
        /// </summary>
        /// <value>The teacher subjects.</value>
        public ICollection<RoleTeacher> RoleTeachers { get; set; }

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

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }
    }
}