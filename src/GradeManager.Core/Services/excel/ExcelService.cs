using ExcelDataReader;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;

namespace GradeManager.Core.Services
{
    public class ExcelService : IExcelService
    {
        #region Tables

        private readonly List<Deutsch> deutsch = new List<Deutsch>();
        private readonly List<Englisch> englisch = new List<Englisch>();
        private readonly List<Ethik> ethik = new List<Ethik>();
        private readonly List<GesamtEj> gesamtEj = new List<GesamtEj>();
        private readonly List<GesamtHj> gesamtHj = new List<GesamtHj>();
        private readonly List<Lehrer> lehrer = new List<Lehrer>();
        private readonly List<Mathe> mathe = new List<Mathe>();
        private readonly List<Musik> musik = new List<Musik>();
        private readonly List<Religion> religion = new List<Religion>();
        private readonly List<Sachkunde> sachkunde = new List<Sachkunde>();
        private readonly List<Sport> sport = new List<Sport>();
        private readonly List<Werken> werken = new List<Werken>();

        #endregion Tables

        private DataSet dataSet;

        #region InterfaceMethods

        public List<Deutsch> GetDeutsch()
        {
            return deutsch;
        }

        public List<Mathe> GetMathe()
        {
            return mathe;
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void OpenFile(string fileName)
        {
            // öffnen in lesemodus
            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        // Gets or sets a callback to obtain configuration options for a
                        // DataTable.
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            // Gets or sets a value indicating whether to use a row from
                            // the data as column names.
                            UseHeaderRow = true
                        }
                    });
                }
            }
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="fileStream">The file stream.</param>
        public void OpenFile(Stream fileStream)
        {
            using (var reader = ExcelReaderFactory.CreateReader(fileStream))
            {
                dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    // Gets or sets a callback to obtain configuration options for a
                    // DataTable.
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                    {
                        // Gets or sets a value indicating whether to use a row from the
                        // data as column names.
                        UseHeaderRow = true
                    }
                });
            }
        }

        #endregion InterfaceMethods

        public void ReadNoteTables()
        {
            // Excel - Spreadsheet/Table Name
            var table = dataSet.Tables[typeof(Mathe).GetCustomAttribute<ExcelTable>().TableName];

            foreach (DataRow row in table.Rows)
            {
                Mathe mathe = new Mathe();

                mathe.Nachname = row[ExcelExtension.GetExcelColumnName(() => mathe.Nachname)].ToString().ToNullableString();
                mathe.Vorname = row[ExcelExtension.GetExcelColumnName(() => mathe.Vorname)].ToString().ToNullableString();
                mathe.T1 = row[ExcelExtension.GetExcelColumnName(() => mathe.T1)].ToString().ToNullable<int>();
                mathe.T2 = row[ExcelExtension.GetExcelColumnName(() => mathe.T2)].ToString().ToNullable<int>();
                mathe.T3 = row[ExcelExtension.GetExcelColumnName(() => mathe.T3)].ToString().ToNullable<int>();
                mathe.T4 = row[ExcelExtension.GetExcelColumnName(() => mathe.T4)].ToString().ToNullable<int>();
                mathe.T5 = row[ExcelExtension.GetExcelColumnName(() => mathe.T5)].ToString().ToNullable<int>();
                mathe.T6 = row[ExcelExtension.GetExcelColumnName(() => mathe.T6)].ToString().ToNullable<int>();
                mathe.T7 = row[ExcelExtension.GetExcelColumnName(() => mathe.T7)].ToString().ToNullable<int>();
                mathe.T8 = row[ExcelExtension.GetExcelColumnName(() => mathe.T8)].ToString().ToNullable<int>();
                mathe.T9 = row[ExcelExtension.GetExcelColumnName(() => mathe.T9)].ToString().ToNullable<int>();
                mathe.T10 = row[ExcelExtension.GetExcelColumnName(() => mathe.T10)].ToString().ToNullable<int>();
                mathe.MwT = row[ExcelExtension.GetExcelColumnName(() => mathe.MwT)].ToString().ToNullable<double>();
                mathe.K1 = row[ExcelExtension.GetExcelColumnName(() => mathe.K1)].ToString().ToNullable<int>();
                mathe.K2 = row[ExcelExtension.GetExcelColumnName(() => mathe.K2)].ToString().ToNullable<int>();
                mathe.K3 = row[ExcelExtension.GetExcelColumnName(() => mathe.K3)].ToString().ToNullable<int>();
                mathe.K4 = row[ExcelExtension.GetExcelColumnName(() => mathe.K4)].ToString().ToNullable<int>();
                mathe.MwK = row[ExcelExtension.GetExcelColumnName(() => mathe.MwK)].ToString().ToNullable<double>();
                mathe.AktN = row[ExcelExtension.GetExcelColumnName(() => mathe.AktN)].ToString().ToNullable<double>();
                mathe.Hj = row[ExcelExtension.GetExcelColumnName(() => mathe.Hj)].ToString().ToNullable<int>();
                mathe.Ej = row[ExcelExtension.GetExcelColumnName(() => mathe.Ej)].ToString().ToNullable<int>();
                mathe.Kommentar = row[ExcelExtension.GetExcelColumnName(() => mathe.Kommentar)].ToString().ToNullableString();

                this.mathe.Add(mathe);
            }
        }
    }
}