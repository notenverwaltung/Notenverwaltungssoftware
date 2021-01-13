namespace GradeManager.Core.Services
{
    [ExcelTable(tableName: "Mu", tableIndex: 7)]
    public class Musik : Subject
    {
        public Musik()
        {
        }

        public Musik(Subject subject) : base(subject)
        {
        }
    }
}