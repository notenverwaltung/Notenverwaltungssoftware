using MvvmCross.Platforms.Wpf.Views;
using Notenverwaltung.WPF.UI.Region;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// GradeManagementView,
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{Notenverwaltung.WPF.UI.ViewModels.GradeManagementViewModel}" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class GradeManagementView : MvxWpfView<Notenverwaltung.WPF.UI.ViewModels.GradeManagementViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GradeManagementView" /> class.
        /// </summary>
        public GradeManagementView()
        {
            this.InitializeComponent();
        }
    }
}