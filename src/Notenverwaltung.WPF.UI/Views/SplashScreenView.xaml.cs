using MvvmCross.Platforms.Wpf.Views;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// Interaction logic for SplashScreenView.xaml
    /// </summary>
    public partial class SplashScreenView : MvxWpfView<Notenverwaltung.WPF.UI.ViewModels.SplashScreenViewModel>
    {
        public SplashScreenView()
        {
            InitializeComponent();
        }
    }
}