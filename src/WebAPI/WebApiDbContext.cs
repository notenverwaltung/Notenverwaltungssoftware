using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebAPI.Models;

namespace WebAPI
{
    /// <summary>
    /// WebApiDbContext.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class WebApiDbContext : DbContext
    {
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

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiDbContext" /> class.
        /// </summary>
        public WebApiDbContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiDbContext" /> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public WebApiDbContext(DbContextOptions<WebApiDbContext> options)
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
        /// <para>
        /// Override this method to configure the database (and other options) to be used
        /// for this context. This method is called for each instance of the context that
        /// is created. The base implementation does nothing.
        /// </para>
        /// <para>
        /// In situations where an instance of <see
        /// cref="T:Microsoft.EntityFrameworkCore.DbContextOptions" /> may or may not have
        /// been passed to the constructor, you can use <see
        /// cref="P:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured" />
        /// to determine if the options have already been set, and skip some or all of the
        /// logic in <see
        /// cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)"
        /// />.
        /// </para>
        /// </summary>
        /// <param name="optionsBuilder">
        /// A builder used to create or modify options for this context. Databases (and
        /// other extensions) typically define extension methods on this object that allow
        /// you to configure the context.
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connection string setzen
            optionsBuilder.UseSqlServer("server=DESKTOP-9ODII40;database=MarkManagementDatabase; Integrated Security = true");
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