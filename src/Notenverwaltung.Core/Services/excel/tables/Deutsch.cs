namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "De", tableIndex: 2)]
    public class Deutsch : Subject
    {
        public Deutsch()
        {
        }

        public Deutsch(Subject subject) : base(subject)
        {
        }
    }
}