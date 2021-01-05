using GradeManager.WPF.UI.Region;
using MvvmCross.Platforms.Wpf.Views;

namespace GradeManager.WPF.UI.Views
{
    /// <summary>
    /// SettingsView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{GradeManager.WPF.UI.ViewModels.SettingsViewModel}" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [MvxWpfPresenter("PageContent", mvxViewPosition.NewOrExsist)]
    public partial class SettingsView : MvxWpfView<GradeManager.WPF.UI.ViewModels.SettingsViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsView" /> class.
        /// </summary>
        public SettingsView()
        {
            this.InitializeComponent();
        }
    }
}