using System.Windows.Documents;
using System.Windows.Media;

namespace GradeManager.WPF.UI.Services
{
    public interface IPrintService
    {
        void PrintDocument(DocumentPaginator document, string description = "Notenverwaltung-DruckService");

        void PrintVisual(Visual visual, string description = "Notenverwaltung-DruckService");

        bool ShowDialog();
    }
}