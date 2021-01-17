namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "Et", tableIndex: 9)]
    public class Ethik : Subject
    {
        public Ethik()
        {
        }

        public Ethik(Subject subject) : base(subject)
        {
        }
    }
}