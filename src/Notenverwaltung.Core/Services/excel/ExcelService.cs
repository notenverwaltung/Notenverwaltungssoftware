using ExcelDataReader;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;

namespace Notenverwaltung.Core.Services
{
    /// <summary>
    /// ExcelService.
    /// </summary>
    /// <seealso cref="Notenverwaltung.Core.Services.IExcelService" />
    public class ExcelService : IExcelService
    {
        #region Variables

        #region Tables

        private readonly ClassSheet classSheet = new ClassSheet();

        #endregion Tables

        private string _dataSetName;
        private DataSet dataSet;

        private Stream fileStream;

        #endregion Variables

        #region InterfaceMethods

        public ExcelService()
        {
            classSheet.Deutsch = new List<Deutsch>();
            classSheet.Englisch = new List<Englisch>();
            classSheet.Ethik = new List<Ethik>();
            classSheet.GesamtEj = new List<GesamtEj>();
            classSheet.GesamtHj = new List<GesamtHj>();
            classSheet.Kunst = new List<Kunst>();
            classSheet.Lehrer = new List<Lehrer>();
            classSheet.Mathe = new List<Mathe>();
            classSheet.Musik = new List<Musik>();
            classSheet.Religion = new List<Religion>();
            classSheet.Sachkunde = new List<Sachkunde>();
            classSheet.Sport = new List<Sport>();
            classSheet.Werken = new List<Werken>();
        }

        public List<Deutsch> GetDeutsch()
        {
            return classSheet.Deutsch;
        }

        public List<Englisch> GetEnglisch()
        {
            return classSheet.Englisch;
        }

        public List<Ethik> GetEthik()
        {
            return classSheet.Ethik;
        }

        public List<GesamtEj> GetGesamtEj()
        {
            return classSheet.GesamtEj;
        }

        public List<GesamtHj> GetGesamtHj()
        {
            return classSheet.GesamtHj;
        }

        public List<Kunst> GetKunst()
        {
            return classSheet.Kunst;
        }

        public List<Lehrer> GetLehrer()
        {
            return classSheet.Lehrer;
        }

        public List<Mathe> GetMathe()
        {
            return classSheet.Mathe;
        }

        public List<Musik> GetMusik()
        {
            return classSheet.Musik;
        }

        public List<Religion> GetReligion()
        {
            return classSheet.Religion;
        }

        public List<Sachkunde> GetSachkunde()
        {
            return classSheet.Sachkunde;
        }

        public ClassSheet GetSheet()
        {
            return classSheet;
        }

        public List<Sport> GetSport()
        {
            return classSheet.Sport;
        }

        public List<Werken> GetWerken()
        {
            return classSheet.Werken;
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void OpenFile(string filePath, string dataSetName = null)
        {
            // öffnen in lesemodus
            this.fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            this._dataSetName = dataSetName;

            OpenFile();
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="fileStream">The file stream.</param>
        public void OpenFile(Stream fileStream, string dataSetName = null)
        {
            this.fileStream = fileStream;
            this._dataSetName = dataSetName;

            OpenFile();
        }

        public void ReadTables()
        {
            DataTable table;

            // Mathe
            table = dataSet.Tables[typeof(Mathe).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Mathe.Add(new Mathe(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Deutsch
            table = dataSet.Tables[typeof(Deutsch).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Deutsch.Add(new Deutsch(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Englisch
            table = dataSet.Tables[typeof(Englisch).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Englisch.Add(new Englisch(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Kunst
            table = dataSet.Tables[typeof(Kunst).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Kunst.Add(new Kunst(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Sachkunde
            table = dataSet.Tables[typeof(Sachkunde).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Sachkunde.Add(new Sachkunde(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Religion
            table = dataSet.Tables[typeof(Religion).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Religion.Add(new Religion(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Ethik
            table = dataSet.Tables[typeof(Ethik).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Ethik.Add(new Ethik(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Sport
            table = dataSet.Tables[typeof(Sport).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Sport.Add(new Sport(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Musik
            table = dataSet.Tables[typeof(Musik).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Musik.Add(new Musik(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Werken
            table = dataSet.Tables[typeof(Werken).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Werken.Add(new Werken(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Lehrer
            table = dataSet.Tables[typeof(Lehrer).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.Lehrer.Add(new Lehrer(ExcelModelHelper.ExcelToTeacher(row)));
            }

            // GesamtEj
            table = dataSet.Tables[typeof(GesamtEj).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.GesamtEj.Add(new GesamtEj(ExcelModelHelper.ExcelToTotal(row)));
            }

            // GesamtHj
            table = dataSet.Tables[typeof(GesamtHj).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                classSheet.GesamtHj.Add(new GesamtHj(ExcelModelHelper.ExcelToTotal(row)));
            }
        }

        #endregion InterfaceMethods

        #region PrivateMethods

        private void OpenFile()
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

            fileStream.Dispose();

            this.dataSet.DataSetName = _dataSetName;
            this.classSheet.Name = _dataSetName;
        }

        #endregion PrivateMethods
    }
}