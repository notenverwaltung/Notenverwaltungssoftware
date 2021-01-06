using GradeManager.WPF.UI.Region;
using MvvmCross.Platforms.Wpf.Views;

namespace GradeManager.WPF.UI.Views
{
    /// <summary>
    /// GradeManagementView,
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{GradeManager.WPF.UI.ViewModels.GradeManagementViewModel}" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class GradeManagementView : MvxWpfView<GradeManager.WPF.UI.ViewModels.GradeManagementViewModel>
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