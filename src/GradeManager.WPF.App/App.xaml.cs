namespace GradeManager.WPF.App
{
    using MvvmCross.Core;
    using MvvmCross.Platforms.Wpf.Views;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        /// <summary>
        /// Registers the setup.
        /// </summary>
        protected override void RegisterSetup()
        {
            base.RegisterSetup();
            //this.RegisterSetupType<MvxWpfSetup<SimTuning.WPF.UI.MvxApp>>();
        }
    }
}