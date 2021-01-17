using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Data.Common;

namespace Notenverwaltung.Test
{
    /// <summary>
    /// sqlite-in-Memory-Datenbank.
    /// -Die Datenbank wird erstellt, wenn die Verbindung mit ihr geöffnet wird.
    /// -Die Datenbank wird gelöscht, wenn die Verbindung mit der Datenbank geschlossen
    /// wird.
    /// </summary>
    /// <seealso cref="GradeManager.Test.ItemsControllerTest" />
    /// <seealso cref="System.IDisposable" />
    public class InMemoryControllerTest : BaseControllerTest, IDisposable
    {
        private readonly DbConnection _connection;

        public InMemoryControllerTest()
            : base(
                new DbContextOptionsBuilder<DatabaseContext>()
                    .UseInMemoryDatabase(databaseName: "TestDataBase")
                    .Options)
        {
            _connection = RelationalOptionsExtension.Extract(ContextOptions).Connection;
        }

        public void Dispose() => _connection.Dispose();

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();
        }
    }
}