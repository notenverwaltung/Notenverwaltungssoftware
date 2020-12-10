namespace Data
{
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    /// <summary>
    /// Main Funktionalität der DB.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class DatabaseContext : DbContext
    {
        #region DataSets

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        /// <value>The class.</value>
        public DbSet<ClassModel> Class { get; set; }

        /// <summary>
        /// Gets or sets the student.
        /// </summary>
        /// <value>The student.</value>
        public DbSet<StudentModel> Student { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public DbSet<SubjectModel> Subject { get; set; }

        /// <summary>
        /// Gets or sets the teacher.
        /// </summary>
        /// <value>The teacher.</value>
        public DbSet<TeacherModel> Teacher { get; set; }

        #endregion DataSets

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseContext" /> class.
        /// </summary>
        public DatabaseContext()
        {
        }

        /// <summary>
        /// Aufgerufen beim speichern der Entitys.
        /// </summary>
        /// <returns>The Number of state entries.</returns>
        public override int SaveChanges()
        {
            var entries = this.ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntityModel && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                // Modified Date
                ((BaseEntityModel)entityEntry.Entity).UpdatedDate = DateTime.Now;

                // Creation Date
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntityModel)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        /// <summary>
        /// einmaliger Aufruf.
        /// </summary>
        /// <param name="options">Optionen.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL($"server={DatabaseSettings.Server};database={DatabaseSettings.Database};user={DatabaseSettings.User};password={DatabaseSettings.Password}");
        }

        /// <summary>
        /// beim kreieren der Models.
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}