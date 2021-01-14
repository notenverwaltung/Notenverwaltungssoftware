using ExcelDataReader;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;

namespace GradeManager.Core.Services
{
    /// <summary>
    /// ExcelService.
    /// </summary>
    /// <seealso cref="GradeManager.Core.Services.IExcelService" />
    public class ExcelService : IExcelService
    {
        #region Variables

        #region Tables

        private readonly List<Deutsch> deutsch = new List<Deutsch>();
        private readonly List<Englisch> englisch = new List<Englisch>();
        private readonly List<Ethik> ethik = new List<Ethik>();
        private readonly List<GesamtEj> gesamtEj = new List<GesamtEj>();
        private readonly List<GesamtHj> gesamtHj = new List<GesamtHj>();
        private readonly List<Kunst> kunst = new List<Kunst>();
        private readonly List<Lehrer> lehrer = new List<Lehrer>();
        private readonly List<Mathe> mathe = new List<Mathe>();
        private readonly List<Musik> musik = new List<Musik>();
        private readonly List<Religion> religion = new List<Religion>();
        private readonly List<Sachkunde> sachkunde = new List<Sachkunde>();
        private readonly List<Sport> sport = new List<Sport>();
        private readonly List<Werken> werken = new List<Werken>();

        #endregion Tables

        private DataSet dataSet;
        private Stream fileStream;

        #endregion Variables

        #region InterfaceMethods

        public List<Deutsch> GetDeutsch()
        {
            return deutsch;
        }

        public List<Englisch> GetEnglisch()
        {
            return englisch;
        }

        public List<Ethik> GetEthik()
        {
            return ethik;
        }

        public List<GesamtEj> GetGesamtEj()
        {
            return gesamtEj;
        }

        public List<GesamtHj> GetGesamtHj()
        {
            return gesamtHj;
        }

        public List<Kunst> GetKunst()
        {
            return kunst;
        }

        public List<Lehrer> GetLehrer()
        {
            return lehrer;
        }

        public List<Mathe> GetMathe()
        {
            return mathe;
        }

        public List<Musik> GetMusik()
        {
            return musik;
        }

        public List<Religion> GetReligion()
        {
            return religion;
        }

        public List<Sachkunde> GetSachkunde()
        {
            return sachkunde;
        }

        public List<Sport> GetSport()
        {
            return sport;
        }

        public List<Werken> GetWerken()
        {
            return werken;
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void OpenFile(string fileName)
        {
            // öffnen in lesemodus
            fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            OpenFile();
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="fileStream">The file stream.</param>
        public void OpenFile(Stream fileStream)
        {
            this.fileStream = fileStream;
            OpenFile();
        }

        public void ReadTables()
        {
            DataTable table;

            // Mathe
            table = dataSet.Tables[typeof(Mathe).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                mathe.Add(new Mathe(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Deutsch
            table = dataSet.Tables[typeof(Deutsch).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                deutsch.Add(new Deutsch(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Englisch
            table = dataSet.Tables[typeof(Englisch).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                englisch.Add(new Englisch(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Kunst
            table = dataSet.Tables[typeof(Kunst).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                kunst.Add(new Kunst(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Sachkunde
            table = dataSet.Tables[typeof(Sachkunde).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                sachkunde.Add(new Sachkunde(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Religion
            table = dataSet.Tables[typeof(Religion).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                religion.Add(new Religion(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Ethik
            table = dataSet.Tables[typeof(Ethik).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                ethik.Add(new Ethik(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Sport
            table = dataSet.Tables[typeof(Sport).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                sport.Add(new Sport(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Musik
            table = dataSet.Tables[typeof(Musik).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                musik.Add(new Musik(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Werken
            table = dataSet.Tables[typeof(Werken).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                werken.Add(new Werken(ExcelModelHelper.ExcelToSubject(row)));
            }

            // Lehrer
            table = dataSet.Tables[typeof(Lehrer).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                lehrer.Add(new Lehrer(ExcelModelHelper.ExcelToTeacher(row)));
            }

            // GesamtEj
            table = dataSet.Tables[typeof(GesamtEj).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                gesamtEj.Add(new GesamtEj(ExcelModelHelper.ExcelToTotal(row)));
            }

            // GesamtHj
            table = dataSet.Tables[typeof(GesamtHj).GetCustomAttribute<ExcelTable>().TableName];
            foreach (DataRow row in table.Rows)
            {
                gesamtHj.Add(new GesamtHj(ExcelModelHelper.ExcelToTotal(row)));
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
        }

        #endregion PrivateMethods
    }
}