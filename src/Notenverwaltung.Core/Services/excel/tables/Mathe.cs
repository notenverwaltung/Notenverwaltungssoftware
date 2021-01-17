namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "Ma", tableIndex: 1)]
    public class Mathe : Subject
    {
        public Mathe()
        {
        }

        public Mathe(Subject subject) : base(subject)
        {
        }
    }
}