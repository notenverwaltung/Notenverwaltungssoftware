using MvvmCross.Platforms.Wpf.Views;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// Interaction logic for SplashScreenWindow.xaml
    /// </summary>
    public partial class SplashScreenWindowView : MvxWpfView<Notenverwaltung.WPF.UI.ViewModels.SplashScreenViewModel>
    {
        public SplashScreenWindowView()
        {
            InitializeComponent();
        }
    }
}