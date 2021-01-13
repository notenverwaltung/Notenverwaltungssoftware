using System;
using System.Reflection;

namespace GradeManager.Core.Services
{
    public class Total : ITotal, IPeople
    {
        [ExcelColumn(columnName: "De", columnIndex: "D")]
        public int? Deutsch { get; set; }

        [ExcelColumn(columnName: "En", columnIndex: "F")]
        public int? Englisch { get; set; }

        [ExcelColumn(columnName: "Et", columnIndex: "K")]
        public int? Ethik { get; set; }

        [ExcelColumn(columnName: "Ku", columnIndex: "G")]
        public int? Kunst { get; set; }

        [ExcelColumn(columnName: "Ma", columnIndex: "C")]
        public int? Mathe { get; set; }

        [ExcelColumn(columnName: "Mu", columnIndex: "I")]
        public int? Musik { get; set; }

        [ExcelColumn(columnName: "MW-S", columnIndex: "M")]
        public double? MwS { get; set; }

        [ExcelColumn(columnName: "Name", columnIndex: "A")]
        public string Nachname { get; set; }

        [ExcelColumn(columnName: "Re", columnIndex: "L")]
        public int? Religion { get; set; }

        [ExcelColumn(columnName: "Sk", columnIndex: "E")]
        public int? Sachkunde { get; set; }

        [ExcelColumn(columnName: "Sp", columnIndex: "J")]
        public int? Sport { get; set; }

        [ExcelColumn(columnName: "Vorname", columnIndex: "B")]
        public string Vorname { get; set; }

        [ExcelColumn(columnName: "We", columnIndex: "H")]
        public int? Werken { get; set; }

        public Total()
        {
        }

        public Total(Total total)
        {
            Type t = total.GetType();
            foreach (FieldInfo fieldInf in t.GetFields())
            {
                fieldInf.SetValue(this, fieldInf.GetValue(total));
            }
            foreach (PropertyInfo propInf in t.GetProperties())
            {
                propInf.SetValue(this, propInf.GetValue(total));
            }
        }
    }
}