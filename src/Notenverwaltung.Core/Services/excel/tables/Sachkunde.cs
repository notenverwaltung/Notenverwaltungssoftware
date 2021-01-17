namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "Sk", tableIndex: 3)]
    public class Sachkunde : Subject
    {
        public Sachkunde()
        {
        }

        public Sachkunde(Subject subject) : base(subject)
        {
        }
    }
}