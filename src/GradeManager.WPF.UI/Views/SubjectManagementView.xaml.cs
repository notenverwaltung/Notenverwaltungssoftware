using GradeManager.WPF.UI.Region;
using MvvmCross.Platforms.Wpf.Views;

namespace GradeManager.WPF.UI.Views
{
    /// <summary>
    /// SubjectManagementView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{GradeManager.WPF.UI.ViewModels.SubjectManagementViewModel}" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class SubjectManagementView : MvxWpfView<GradeManager.WPF.UI.ViewModels.SubjectManagementViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectManagementView" /> class.
        /// </summary>
        public SubjectManagementView()
        {
            this.InitializeComponent();
        }
    }
}