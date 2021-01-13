namespace GradeManager.Core.Services
{
    [ExcelTable(tableName: "En", tableIndex: 4)]
    public class Englisch : Subject
    {
        public Englisch()
        {
        }

        public Englisch(Subject subject) : base(subject)
        {
        }
    }
}