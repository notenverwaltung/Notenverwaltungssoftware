using MvvmCross.Platforms.Wpf.Views;
using Notenverwaltung.WPF.UI.Region;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// SubjectManagementView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{Notenverwaltung.WPF.UI.ViewModels.SubjectManagementViewModel}" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class SubjectManagementView : MvxWpfView<Notenverwaltung.WPF.UI.ViewModels.SubjectManagementViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectManagementView" /> class.
        /// </summary>
        public SubjectManagementView()
        {
            this.InitializeComponent();
        }

        private void UIElement_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //until we had a StaysOpen glag to Drawer, this will help with scroll bars
            var dependencyObject = Mouse.Captured as DependencyObject;

            while (dependencyObject != null)
            {
                if (dependencyObject is ScrollBar) return;
                dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
            }
        }
    }
}