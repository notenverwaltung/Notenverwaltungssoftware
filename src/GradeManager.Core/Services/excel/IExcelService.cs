using System.IO;

namespace GradeManager.Core.Services
{
    public interface IExcelService
    {
        void OpenFile(string fileName);

        void OpenFile(Stream fileStream);

        void ReadNoteTables();
    }
}