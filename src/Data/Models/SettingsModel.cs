namespace Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// PersonModel.
    /// </summary>
    /// <seealso cref="Data.Models.BaseEntityModel" />
    public class SettingsModel : BaseEntityModel
    {
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