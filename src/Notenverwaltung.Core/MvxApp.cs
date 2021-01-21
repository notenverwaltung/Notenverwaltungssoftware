using MvvmCross;
using MvvmCross.ViewModels;
using Notenverwaltung.Core.Services;
using System.Threading.Tasks;

namespace Notenverwaltung.Core
{
    /// <summary>
    /// BASE Application.
    /// </summary>
    /// <seealso cref="MvvmCross.ViewModels.MvxApplication" />
    public class MvxApp : MvxApplication
    {
        /// <summary>
        /// Any initialization steps that can be done in the background.
        /// </summary>
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterSingleton(Plugin.Settings.CrossSettings.Current);

            Mvx.IoCProvider.RegisterSingleton<IExcelService>(() => new ExcelService());

            Mvx.IoCProvider.RegisterSingleton<IUserPermissions>(() => new UserPermissions());

            Mvx.IoCProvider.RegisterSingleton<ILdapService>(() => new LdapService());

            //var context = new DatabaseContext();
            //Mvx.IoCProvider.RegisterSingleton<ISubjectsController>(() => new SubjectsController(context));

            base.Initialize();
        }

        /// <summary>
        /// If the application is restarted (eg primary activity on Android can be
        /// restarted) this method will be called before Startup is called again.
        /// </summary>
        public override void Reset()
        {
            base.Reset();
        }

        /// <summary>
        /// Do any UI bound startup actions here.
        /// </summary>
        public override Task Startup()
        {
            return base.Startup();
        }
    }
}