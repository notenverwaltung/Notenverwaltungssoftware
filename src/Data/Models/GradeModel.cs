namespace Data.Models
{
    using Data.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// GradeModel.
    /// </summary>
    /// <seealso cref="Data.Models.BaseEntityModel" />
    public class GradeModel : BaseEntityModel
    {
        /// <summary>
        /// Gets or sets the abbreviation.
        /// </summary>
        /// <value>The abbreviation.</value>
        [MaxLength(1)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the grade.
        /// </summary>
        /// <value>The grade.</value>
        [MaxLength(1)]
        public int Grade { get; set; }

        /// <summary>
        /// Gets or sets the grade enum.
        /// </summary>
        /// <value>The grade enum.</value>
        public GradeEnum GradeEnum { get; set; }

        /// <summary>
        /// Gets or sets the person.
        /// </summary>
        /// <value>The person.</value>
        public virtual PersonModel Person { get; set; }

        /// <summary>
        /// Gets or sets the person identifier.
        /// </summary>
        /// <value>The person identifier.</value>
        [ForeignKey("Person")]
        public int PersonId { get; set; }
    }
}