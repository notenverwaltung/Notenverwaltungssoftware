using System;
using System.Reflection;

namespace Notenverwaltung.Core.Services
{
    public class Total : ITotal, IPeople
    {
        [ExcelColumn(columnName: "De", columnIndex: "D")]
        public double? Deutsch { get; set; }

        [ExcelColumn(columnName: "En", columnIndex: "F")]
        public double? Englisch { get; set; }

        [ExcelColumn(columnName: "Et", columnIndex: "K")]
        public double? Ethik { get; set; }

        [ExcelColumn(columnName: "Ku", columnIndex: "G")]
        public double? Kunst { get; set; }

        [ExcelColumn(columnName: "Ma", columnIndex: "C")]
        public double? Mathe { get; set; }

        [ExcelColumn(columnName: "Mu", columnIndex: "I")]
        public double? Musik { get; set; }

        [ExcelColumn(columnName: "MW-S", columnIndex: "M")]
        public double? MwS { get; set; }

        [ExcelColumn(columnName: "Name", columnIndex: "A")]
        public string Nachname { get; set; }

        [ExcelColumn(columnName: "Re", columnIndex: "L")]
        public double? Religion { get; set; }

        [ExcelColumn(columnName: "Sk", columnIndex: "E")]
        public double? Sachkunde { get; set; }

        [ExcelColumn(columnName: "Sp", columnIndex: "J")]
        public double? Sport { get; set; }

        [ExcelColumn(columnName: "Vorname", columnIndex: "B")]
        public string Vorname { get; set; }

        [ExcelColumn(columnName: "We", columnIndex: "H")]
        public double? Werken { get; set; }

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