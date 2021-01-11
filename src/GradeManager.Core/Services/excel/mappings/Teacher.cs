namespace GradeManager.Core.Services
{
    public class Teacher : IPeople, ITeacher
    {
        [ExcelColumn(columnName: "Anrede")]
        public string Anrede { get; set; }

        [ExcelColumn(columnName: "Fach")]
        public string Fach { get; set; }

        [ExcelColumn(columnName: "Klassenleiter")]
        public bool Klassenleiter { get; set; }

        [ExcelColumn(columnName: "Kürzel")]
        public string Kuerzel { get; set; }

        [ExcelColumn(columnName: "Name", columnIndex: "D")]
        public string Nachname { get; set; }

        [ExcelColumn(columnName: "Vorname", columnIndex: "E")]
        public string Vorname { get; set; }
    }
}