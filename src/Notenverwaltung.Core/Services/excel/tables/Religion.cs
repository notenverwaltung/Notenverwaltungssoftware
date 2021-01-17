namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "Re", tableIndex: 10)]
    public class Religion : Subject
    {
        public Religion()
        {
        }

        public Religion(Subject subject) : base(subject)
        {
        }
    }
}