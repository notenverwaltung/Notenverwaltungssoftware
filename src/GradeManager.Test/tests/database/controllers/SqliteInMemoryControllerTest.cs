using Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Data.Common;

namespace GradeManager.Test
{
    /// <summary>
    /// sqlite-in-Memory-Datenbank.
    /// -Die Datenbank wird erstellt, wenn die Verbindung mit ihr geöffnet wird.
    /// -Die Datenbank wird gelöscht, wenn die Verbindung mit der Datenbank geschlossen
    /// wird.
    /// </summary>
    /// <seealso cref="GradeManager.Test.BaseControllerTest" />
    /// <seealso cref="System.IDisposable" />
    public class SqliteInMemoryControllerTest : BaseControllerTest, IDisposable
    {
        private readonly DbConnection _connection;

        public SqliteInMemoryControllerTest()
            : base(
                new DbContextOptionsBuilder<DatabaseContext>()
                    .UseSqlite(CreateInMemoryDatabase())
                    .Options)
        {
            _connection = RelationalOptionsExtension.Extract(ContextOptions).Connection;
        }

        public void Dispose() => _connection.Dispose();

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();
        }

        /// <summary>
        /// Erstellt eine sqlite-in-Memory Database und öffnet die Verbindung.
        /// </summary>
        /// <returns></returns>
        private static DbConnection CreateInMemoryDatabase()
        {
            var connection = new SqliteConnection("Filename=:memory:");

            connection.Open();

            return connection;
        }
    }
}