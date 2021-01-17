using System;
using System.Reflection;

namespace Notenverwaltung.Core.Services
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

        public Teacher()
        {
        }

        public Teacher(Teacher teacher)
        {
            Type t = teacher.GetType();
            foreach (FieldInfo fieldInf in t.GetFields())
            {
                fieldInf.SetValue(this, fieldInf.GetValue(teacher));
            }
            foreach (PropertyInfo propInf in t.GetProperties())
            {
                propInf.SetValue(this, propInf.GetValue(teacher));
            }
        }
    }
}