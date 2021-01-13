namespace GradeManager.Core.Services
{
    [ExcelTable(tableName: "Sp", tableIndex: 8)]
    public class Sport : Subject
    {
        public Sport()
        {
        }

        public Sport(Subject subject) : base(subject)
        {
        }
    }
}