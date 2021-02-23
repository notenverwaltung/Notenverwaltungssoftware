using System.Collections.Generic;

namespace Notenverwaltung.Core.Services.excel.helpers
{
    /// <summary>
    /// DatabaseModelHelper.
    /// TODO: implement
    /// </summary>
    public class DatabaseModelHelper
    {
        public static List<Data.Models.Teacher> GetTeachers(ClassSheet classSheet)
        {
            List<Data.Models.Teacher> dbTeachers = new List<Data.Models.Teacher>();

            foreach (var excelTeacher in classSheet.Lehrer)
            {
                Data.Models.Teacher dbTeacher = new Data.Models.Teacher();

                dbTeacher.FirstName = excelTeacher.Vorname;
                dbTeacher.LastName = excelTeacher.Nachname;
                dbTeacher.Abbreviation = excelTeacher.Kuerzel;

                dbTeachers.Add(dbTeacher);
            }

            return dbTeachers;
        }
    }
}