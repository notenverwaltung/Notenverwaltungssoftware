using Data;
using Microsoft.EntityFrameworkCore;

namespace Notenverwaltung.Test
{
    public class SqliteControllerTest : BaseControllerTest
    {
        public SqliteControllerTest()
            : base(
                new DbContextOptionsBuilder<DatabaseContext>()
                    .UseSqlite("Filename=Test.db")
                    .Options)
        {
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();
        }
    }
}