namespace Notenverwaltung.WPFCore.App
{
    using MvvmCross.Core;
    using MvvmCross.Platforms.Wpf.Views;

    /// <summary>
    /// App.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxApplication" />
    public partial class App : MvxApplication
    {
        /// <summary>
        /// Registers the setup.
        /// </summary>
        protected override void RegisterSetup()
        {
            base.RegisterSetup();
            this.RegisterSetupType<MvxWpfSetup<Notenverwaltung.WPF.UI.MvxApp>>();
        }
    }
}