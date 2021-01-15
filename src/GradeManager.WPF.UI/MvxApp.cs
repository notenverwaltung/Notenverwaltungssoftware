using GradeManager.Core.Services;
using GradeManager.WPF.UI.Services;
using MvvmCross;

namespace GradeManager.WPF.UI
{
    /// <summary>
    /// WPF-spezifische App.
    /// </summary>
    /// <seealso cref="MvvmCross.ViewModels.MvxApplication" />
    public class MvxApp : GradeManager.Core.MvxApp
    {
        /// <summary>
        /// Any initialization steps that can be done in the background
        /// </summary>
        public override void Initialize()
        {
            this.RegisterAppStart<GradeManager.WPF.UI.ViewModels.MenuViewModel>();

            Mvx.IoCProvider.RegisterType<IThemeService>(() => new ThemeService());

            Mvx.IoCProvider.RegisterType<IPrintService>(() => new PrintService());

            base.Initialize();
        }
    }
}