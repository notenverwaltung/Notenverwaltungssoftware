﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Unterricht.
    /// </summary>
    /// <seealso cref="Data.Models.BaseModel" />
    public class Lesson : BaseModel
    {
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
        /// Gets or sets the school year.
        /// </summary>
        /// <value>The school year.</value>
        public SchoolYear SchoolYear { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public Subject Subject { get; set; }

        /// <summary>
        /// Gets or sets the teacher.
        /// </summary>
        /// <value>The teacher.</value>
        public Teacher Teacher { get; set; }
    }
}