using GradeManager.WPF.UI.Region;
using MvvmCross.Platforms.Wpf.Views;

namespace GradeManager.WPF.UI.Views
{
    /// <summary>
    /// ClassManagementView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{GradeManager.WPF.UI.ViewModels.ClassManagementViewModel}" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class ClassManagementView : MvxWpfView<GradeManager.WPF.UI.ViewModels.ClassManagementViewModel>
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