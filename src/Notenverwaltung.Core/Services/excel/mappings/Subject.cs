using System;
using System.Reflection;

namespace Notenverwaltung.Core.Services
{
    public class Subject : ISubject, IPeople
    {
        [ExcelColumn(columnName: "AktN", columnIndex: "S")]
        public double? AktN { get; set; }

        [ExcelColumn(columnName: "Ej", columnIndex: "U")]
        public int? Ej { get; set; }

        [ExcelColumn(columnName: "Hj", columnIndex: "T")]
        public int? Hj { get; set; }

        [ExcelColumn(columnName: "K1", columnIndex: "N")]
        public int? K1 { get; set; }

        [ExcelColumn(columnName: "K2", columnIndex: "O")]
        public int? K2 { get; set; }

        [ExcelColumn(columnName: "K3", columnIndex: "P")]
        public int? K3 { get; set; }

        [ExcelColumn(columnName: "K4", columnIndex: "Q")]
        public int? K4 { get; set; }

        [ExcelColumn(columnName: "Kommentar", columnIndex: "V")]
        public string Kommentar { get; set; }

        [ExcelColumn(columnName: "MW-K", columnIndex: "R")]
        public double? MwK { get; set; }

        [ExcelColumn(columnName: "MW-T", columnIndex: "M")]
        public double? MwT { get; set; }

        [ExcelColumn(columnName: "Name", columnIndex: "A")]
        public string Nachname { get; set; }

        [ExcelColumn(columnName: "T1", columnIndex: "C")]
        public int? T1 { get; set; }

        [ExcelColumn(columnName: "T10", columnIndex: "L")]
        public int? T10 { get; set; }

        [ExcelColumn(columnName: "T2", columnIndex: "D")]
        public int? T2 { get; set; }

        [ExcelColumn(columnName: "T3", columnIndex: "E")]
        public int? T3 { get; set; }

        [ExcelColumn(columnName: "T4", columnIndex: "F")]
        public int? T4 { get; set; }

        [ExcelColumn(columnName: "T5", columnIndex: "G")]
        public int? T5 { get; set; }

        [ExcelColumn(columnName: "T6", columnIndex: "H")]
        public int? T6 { get; set; }

        [ExcelColumn(columnName: "T7", columnIndex: "I")]
        public int? T7 { get; set; }

        [ExcelColumn(columnName: "T8", columnIndex: "J")]
        public int? T8 { get; set; }

        [ExcelColumn(columnName: "T9", columnIndex: "K")]
        public int? T9 { get; set; }

        [ExcelColumn(columnName: "Vorname", columnIndex: "B")]
        public string Vorname { get; set; }

        public Subject()
        {
        }

        public Subject(Subject subject)
        {
            Type t = subject.GetType();
            foreach (FieldInfo fieldInf in t.GetFields())
            {
                fieldInf.SetValue(this, fieldInf.GetValue(subject));
            }
            foreach (PropertyInfo propInf in t.GetProperties())
            {
                propInf.SetValue(this, propInf.GetValue(subject));
            }

            if (MwK.HasValue)
            {
                MwK = Math.Round(MwK.Value, 1);
            }
            if (MwT.HasValue)
            {
                MwT = Math.Round(MwT.Value, 1);
            }
            if (AktN.HasValue)
            {
                AktN = Math.Round(AktN.Value, 1);
            }
        }
    }
}