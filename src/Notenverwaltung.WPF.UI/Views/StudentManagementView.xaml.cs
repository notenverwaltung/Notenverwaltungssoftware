using MvvmCross.Platforms.Wpf.Views;
using Notenverwaltung.WPF.UI.Region;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// TeacherManagementView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{Notenverwaltung.WPF.UI.ViewModels.TeacherManagementViewModel}" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class StudentManagementView : MvxWpfView<Notenverwaltung.WPF.UI.ViewModels.StudentManagementViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeacherManagementView" /> class.
        /// </summary>
        public StudentManagementView()
        {
            this.InitializeComponent();
        }
    }
}