using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    /// <summary>
    /// Schuljahr.
    /// </summary>
    /// <seealso cref="WebAPI.Models.BaseModel" />
    public class SchoolYear : BaseModel
    {
        /// <summary>
        /// Gets or sets the lessons.
        /// </summary>
        /// <value>The lessons.</value>
        public ICollection<Class> Classes { get; set; }

        /// <summary>
        /// Gets or sets the date from.
        /// </summary>
        /// <value>The date from.</value>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Gets or sets the date to.
        /// </summary>
        /// <value>The date to.</value>
        public DateTime DateTo { get; set; }
    }
}