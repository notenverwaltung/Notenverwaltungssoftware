namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// ClassModel.
    /// </summary>
    /// <seealso cref="Data.Models.BaseEntityModel" />
    public class ClassModel : BaseEntityModel
    {
        /// <summary>
        /// Gets or sets the abbreviation.
        /// </summary>
        /// <value>The abbreviation.</value>
        [MaxLength(1)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the grade.
        /// </summary>
        /// <value>The grade.</value>
        [Required]
        [MaxLength(1)]
        public int Grade { get; set; }
    }
}