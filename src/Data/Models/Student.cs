using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Schüler.
    /// </summary>
    /// <seealso cref="Data.Models.Person" />
    public class Student : Person
    {
        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        /// <value>The class.</value>
        public Class Class { get; set; }

        /// <summary>
        /// Gets or sets the markings.
        /// </summary>
        /// <value>The markings.</value>
        public ICollection<Mark> Marks { get; set; }

        /// <summary>
        /// Gets or sets the teacher.
        /// </summary>
        /// <value>The teacher.</value>
        public Teacher Teacher { get; set; }
    }
}