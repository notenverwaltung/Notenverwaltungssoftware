namespace GradeManager.Core.Services
{
    [ExcelTable(tableName: "We", tableIndex: 6)]
    public class Werken : Subject
    {
        public Werken()
        {
        }

        public Werken(Subject subject) : base(subject)
        {
        }
    }
}