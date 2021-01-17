using MvvmCross.Platforms.Wpf.Presenters;
using MvvmCross.ViewModels;
using Notenverwaltung.WPF.UI.Region;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Controls;

namespace Notenverwaltung.WPFCore.App
{
    /// <summary>
    /// WPF dotnetframework app start.
    /// </summary>
    /// <typeparam name="TApplication">The type of the application.</typeparam>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Core.MvxWpfSetup{TApplication}" />
    public class MvxWpfSetup<TApplication> : MvvmCross.Platforms.Wpf.Core.MvxWpfSetup<TApplication>
        where TApplication : class, IMvxApplication, new()
    {
        /// <summary>
        /// Gets the view assemblies.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Assembly> GetViewAssemblies()
        {
            var list = new List<Assembly>();
            list.AddRange(base.GetViewAssemblies());
            list.Add(typeof(Notenverwaltung.WPF.UI.Views.MainWindow).Assembly);
            return list.ToArray();
        }

        /// <summary>
        /// Creates the view presenter.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        protected override IMvxWpfViewPresenter CreateViewPresenter(ContentControl root)
        {
            return new MvxWpfPresenter(root);
        }
    }
}