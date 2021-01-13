namespace GradeManager.Core.Services
{
    [ExcelTable(tableName: "Ku", tableIndex: 5)]
    public class Kunst : Subject
    {
        public Kunst()
        {
        }

        public Kunst(Subject subject) : base(subject)
        {
        }
    }
}