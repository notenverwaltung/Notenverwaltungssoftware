using System.Collections.Generic;
using System.Data;

namespace GradeManager.Core.Services
{
    public static class ExcelToModelExtension
    {
        /// <summary>
        /// Excels to subject.
        /// </summary>
        /// <param name="subjects">The subjects.</param>
        /// <param name="rows">The rows.</param>
        public static Subject ExcelToSubject(DataRow row)
        {
            Subject subject = new Subject();

            subject.Nachname = row[ExcelExtension.GetExcelColumnName(() => subject.Nachname)].ToString().ToNullableString();
            subject.Vorname = row[ExcelExtension.GetExcelColumnName(() => subject.Vorname)].ToString().ToNullableString();
            subject.T1 = row[ExcelExtension.GetExcelColumnName(() => subject.T1)].ToString().ToNullable<int>();
            subject.T2 = row[ExcelExtension.GetExcelColumnName(() => subject.T2)].ToString().ToNullable<int>();
            subject.T3 = row[ExcelExtension.GetExcelColumnName(() => subject.T3)].ToString().ToNullable<int>();
            subject.T4 = row[ExcelExtension.GetExcelColumnName(() => subject.T4)].ToString().ToNullable<int>();
            subject.T5 = row[ExcelExtension.GetExcelColumnName(() => subject.T5)].ToString().ToNullable<int>();
            subject.T6 = row[ExcelExtension.GetExcelColumnName(() => subject.T6)].ToString().ToNullable<int>();
            subject.T7 = row[ExcelExtension.GetExcelColumnName(() => subject.T7)].ToString().ToNullable<int>();
            subject.T8 = row[ExcelExtension.GetExcelColumnName(() => subject.T8)].ToString().ToNullable<int>();
            subject.T9 = row[ExcelExtension.GetExcelColumnName(() => subject.T9)].ToString().ToNullable<int>();
            subject.T10 = row[ExcelExtension.GetExcelColumnName(() => subject.T10)].ToString().ToNullable<int>();
            subject.MwT = row[ExcelExtension.GetExcelColumnName(() => subject.MwT)].ToString().ToNullable<double>();
            subject.K1 = row[ExcelExtension.GetExcelColumnName(() => subject.K1)].ToString().ToNullable<int>();
            subject.K2 = row[ExcelExtension.GetExcelColumnName(() => subject.K2)].ToString().ToNullable<int>();
            subject.K3 = row[ExcelExtension.GetExcelColumnName(() => subject.K3)].ToString().ToNullable<int>();
            subject.K4 = row[ExcelExtension.GetExcelColumnName(() => subject.K4)].ToString().ToNullable<int>();
            subject.MwK = row[ExcelExtension.GetExcelColumnName(() => subject.MwK)].ToString().ToNullable<double>();
            subject.AktN = row[ExcelExtension.GetExcelColumnName(() => subject.AktN)].ToString().ToNullable<double>();
            subject.Hj = row[ExcelExtension.GetExcelColumnName(() => subject.Hj)].ToString().ToNullable<int>();
            subject.Ej = row[ExcelExtension.GetExcelColumnName(() => subject.Ej)].ToString().ToNullable<int>();
            subject.Kommentar = row[ExcelExtension.GetExcelColumnName(() => subject.Kommentar)].ToString().ToNullableString();

            return subject;
        }

        /// <summary>
        /// Excels to teacher.
        /// </summary>
        /// <param name="teachers">The teachers.</param>
        /// <param name="rows">The rows.</param>
        public static Teacher ExcelToTeacher(DataRow row)
        {
            Teacher teacher = new Teacher();

            teacher.Nachname = row[ExcelExtension.GetExcelColumnName(() => teacher.Nachname)].ToString().ToNullableString();
            teacher.Vorname = row[ExcelExtension.GetExcelColumnName(() => teacher.Vorname)].ToString().ToNullableString();
            teacher.Anrede = row[ExcelExtension.GetExcelColumnName(() => teacher.Anrede)].ToString().ToNullableString();
            teacher.Fach = row[ExcelExtension.GetExcelColumnName(() => teacher.Fach)].ToString().ToNullableString();
            teacher.Klassenleiter = row[ExcelExtension.GetExcelColumnName(() => teacher.Klassenleiter)].ToString().KlassenleiterToBool();
            teacher.Kuerzel = row[ExcelExtension.GetExcelColumnName(() => teacher.Kuerzel)].ToString().ToNullableString();

            return teacher;
        }

        /// <summary>
        /// Excels to total.
        /// </summary>
        /// <param name="totals">The totals.</param>
        /// <param name="rows">The rows.</param>
        public static Total ExcelToTotal(DataRow row)
        {
            Total total = new Total();

            total.Vorname = row[ExcelExtension.GetExcelColumnName(() => total.Vorname)].ToString().ToNullableString();
            total.Nachname = row[ExcelExtension.GetExcelColumnName(() => total.Nachname)].ToString().ToNullableString();
            total.Deutsch = row[ExcelExtension.GetExcelColumnName(() => total.Deutsch)].ToString().ToNullable<int>();
            total.Mathe = row[ExcelExtension.GetExcelColumnName(() => total.Mathe)].ToString().ToNullable<int>();
            total.Sachkunde = row[ExcelExtension.GetExcelColumnName(() => total.Sachkunde)].ToString().ToNullable<int>();
            total.Musik = row[ExcelExtension.GetExcelColumnName(() => total.Musik)].ToString().ToNullable<int>();
            total.Englisch = row[ExcelExtension.GetExcelColumnName(() => total.Englisch)].ToString().ToNullable<int>();
            total.Ethik = row[ExcelExtension.GetExcelColumnName(() => total.Ethik)].ToString().ToNullable<int>();
            total.Kunst = row[ExcelExtension.GetExcelColumnName(() => total.Kunst)].ToString().ToNullable<int>();
            total.Sport = row[ExcelExtension.GetExcelColumnName(() => total.Sport)].ToString().ToNullable<int>();
            total.Religion = row[ExcelExtension.GetExcelColumnName(() => total.Religion)].ToString().ToNullable<int>();
            total.Werken = row[ExcelExtension.GetExcelColumnName(() => total.Werken)].ToString().ToNullable<int>();
            total.MwS = row[ExcelExtension.GetExcelColumnName(() => total.MwS)].ToString().ToNullable<double>();

            return total;
        }
    }
}