using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// Interaction logic for SplashScreenWindow.xaml
    /// </summary>
    [MvxWindowPresentation(Identifier = nameof(SplashScreenWindow), Modal = false)]
    public partial class SplashScreenWindow : MvxWindow
    {
        public SplashScreenWindow()
        {
            InitializeComponent();
        }
    }
}