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

            Mvx.IoCProvider.RegisterSingleton<IThemeService>(() => new ThemeService());

            base.Initialize();
        }
    }
}