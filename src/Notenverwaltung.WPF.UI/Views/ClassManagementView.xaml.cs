using MvvmCross.Platforms.Wpf.Views;
using Notenverwaltung.WPF.UI.Region;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// ClassManagementView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{Notenverwaltung.WPF.UI.ViewModels.ClassManagementViewModel}" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class ClassManagementView : MvxWpfView<Notenverwaltung.WPF.UI.ViewModels.ClassManagementViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassManagementView" /> class.
        /// </summary>
        public ClassManagementView()
        {
            this.InitializeComponent();
        }
    }
}