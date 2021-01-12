namespace Data.Models
{
    using Data.Enums;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// TeacherModel.
    /// </summary>
    /// <seealso cref="Data.Models.BaseEntityModel" />
    public class PersonModel : BaseEntityModel
    {
        /// <summary>
        /// Gets or sets the anrede.
        /// </summary>
        /// <value>The anrede.</value>
        public string Anrede { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the kuerzel.
        /// </summary>
        /// <value>The kuerzel.</value>
        public string Kuerzel { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the type of the person.
        /// </summary>
        /// <value>The type of the person.</value>
        public PersonEnum PersonType { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>The settings.</value>
        public virtual SettingsModel Settings { get; set; }
    }
}