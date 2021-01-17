using MvvmCross;
using Notenverwaltung.Core.Services;
using Notenverwaltung.WPF.UI.Services;

namespace Notenverwaltung.WPF.UI
{
    /// <summary>
    /// WPF-spezifische App.
    /// </summary>
    /// <seealso cref="MvvmCross.ViewModels.MvxApplication" />
    public class MvxApp : Notenverwaltung.Core.MvxApp
    {
        /// <summary>
        /// Any initialization steps that can be done in the background
        /// </summary>
        public override void Initialize()
        {
            this.RegisterAppStart<Notenverwaltung.WPF.UI.ViewModels.MenuViewModel>();

            Mvx.IoCProvider.RegisterType<IThemeService>(() => new ThemeService());

            Mvx.IoCProvider.RegisterType<IPrintService>(() => new PrintService());

            base.Initialize();
        }
    }
}