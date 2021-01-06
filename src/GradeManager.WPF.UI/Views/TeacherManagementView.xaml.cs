using GradeManager.WPF.UI.Region;
using MvvmCross.Platforms.Wpf.Views;

namespace GradeManager.WPF.UI.Views
{
    /// <summary>
    /// TeacherManagementView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{GradeManager.WPF.UI.ViewModels.TeacherManagementViewModel}" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class TeacherManagementView : MvxWpfView<GradeManager.WPF.UI.ViewModels.TeacherManagementViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeacherManagementView" /> class.
        /// </summary>
        public TeacherManagementView()
        {
            this.InitializeComponent();
        }
    }
}