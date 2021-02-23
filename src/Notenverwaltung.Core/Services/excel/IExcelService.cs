using System.Collections.Generic;
using System.IO;

namespace Notenverwaltung.Core.Services
{
    /// <summary>
    /// IExcelService.
    /// </summary>
    public interface IExcelService
    {
        List<Deutsch> GetDeutsch();

        List<Englisch> GetEnglisch();

        List<Ethik> GetEthik();

        List<GesamtEj> GetGesamtEj();

        List<GesamtHj> GetGesamtHj();

        List<Kunst> GetKunst();

        List<Lehrer> GetLehrer();

        List<Mathe> GetMathe();

        List<Musik> GetMusik();

        List<Religion> GetReligion();

        List<Sachkunde> GetSachkunde();

        ClassSheet GetSheet();

        List<Sport> GetSport();

        List<Werken> GetWerken();

        void OpenFile(string filePath, string dataSetName = null);

        void OpenFile(Stream fileStream, string dataSetName = null);

        void ReadTables();
    }
}