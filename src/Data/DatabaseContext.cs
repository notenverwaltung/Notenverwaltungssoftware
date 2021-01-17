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
        /// Gets or sets the classes.
        /// </summary>
        /// <value>The classes.</value>
        public DbSet<Class> Classes { get; set; }

        /// <summary>
        /// Gets or sets the lessons.
        /// </summary>
        /// <value>The lessons.</value>
        public DbSet<Lectureship> Lectureship { get; set; }

        /// <summary>
        /// Gets or sets the marks.
        /// </summary>
        /// <value>The marks.</value>
        public DbSet<Mark> Marks { get; set; }

        /// <summary>
        /// Gets or sets the school years.
        /// </summary>
        /// <value>The school years.</value>
        public DbSet<SchoolYear> SchoolYears { get; set; }

        /// <summary>
        /// Gets or sets the students.
        /// </summary>
        /// <value>The students.</value>
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// Gets or sets the subjects.
        /// </summary>
        /// <value>The subjects.</value>
        public DbSet<Subject> Subjects { get; set; }

        /// <summary>
        /// Gets or sets the teachers.
        /// </summary>
        /// <value>The teachers.</value>
        public DbSet<Teacher> Teachers { get; set; }

        /// <summary>
        /// Gets or sets the teacher subjects.
        /// </summary>
        /// <value>The teacher subjects.</value>
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }

        #endregion DataSets

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseContext" /> class.
        /// </summary>
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
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
                .Where(e => e.Entity is BaseModel && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                // Modified Date
                ((BaseModel)entityEntry.Entity).UpdatedDate = DateTime.Now;

                // Creation Date
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseModel)entityEntry.Entity).CreatedDate = DateTime.Now;
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
            options.UseMySQL($"server={DatabaseSettings.Server};" +
                             $"database={DatabaseSettings.Database};" +
                             $"user={DatabaseSettings.User};" +
                             $"password={DatabaseSettings.Password}");
        }

        /// <summary>
        /// Override this method to further configure the model that was discovered by
        /// convention from the entity types exposed in <see
        /// cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived
        /// context. The resulting model may be cached and re-used for subsequent
        /// instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">
        /// The builder being used to construct the model for this context. Databases (and
        /// other extensions) typically define extension methods on this object that allow
        /// you to configure aspects of the model that are specific to a given database.
        /// </param>
        /// <remarks>
        /// If a model is explicitly set on the options for this context (via <see
        /// cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)"
        /// />) then this method will not be run.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasOne(a => a.Class)
                .WithOne(b => b.ClassTeacher)
                .HasForeignKey<Class>(b => b.ClassTeacherId);
            modelBuilder.Entity<Teacher>()
                .HasMany(a => a.Lectureships)
                .WithOne(b => b.Teacher);
            modelBuilder.Entity<Teacher>()
                .HasMany(a => a.Marks)
                .WithOne(b => b.Teacher);

            modelBuilder.Entity<Class>()
                .HasMany(a => a.Students)
                .WithOne(b => b.Class);
            modelBuilder.Entity<Class>()
                .HasMany(a => a.Lectureships)
                .WithOne(b => b.Class);

            modelBuilder.Entity<SchoolYear>()
                .HasMany(a => a.Classes)
                .WithOne(b => b.SchoolYear);

            modelBuilder.Entity<TeacherSubject>()
                .HasOne(a => a.Teacher)
                .WithMany(b => b.TeacherSubjects)
                .HasForeignKey(a => a.TeacherId);
            modelBuilder.Entity<TeacherSubject>()
                .HasOne(a => a.Subject)
                .WithMany(b => b.TeacherSubjects)
                .HasForeignKey(a => a.SubjectId);

            modelBuilder.Entity<Subject>()
                .HasMany(a => a.Lectureships)
                .WithOne(b => b.Subject);
            modelBuilder.Entity<Subject>()
                .HasMany(a => a.Marks)
                .WithOne(b => b.Subject);

            modelBuilder.Entity<Student>()
                .HasMany(a => a.Marks)
                .WithOne(b => b.Student);
        }
    }
}