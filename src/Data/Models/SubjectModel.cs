namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// SubjectModel.
    /// </summary>
    /// <seealso cref="Data.Models.BaseEntityModel" />
    public class SubjectModel : BaseEntityModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}