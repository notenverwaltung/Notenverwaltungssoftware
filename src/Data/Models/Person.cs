using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Person.
    /// </summary>
    public abstract class Person : BaseModel
    {
        /// <summary>
        /// Gets or sets the name of the frist.
        /// </summary>
        /// <value>The name of the frist.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }
    }
}