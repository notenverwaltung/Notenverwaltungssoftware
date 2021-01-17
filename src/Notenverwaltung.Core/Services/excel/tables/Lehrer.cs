namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "Lehrer", tableIndex: 13)]
    public class Lehrer : Teacher
    {
        public Lehrer()
        {
        }

        public Lehrer(Teacher teacher) : base(teacher)
        {
        }
    }
}