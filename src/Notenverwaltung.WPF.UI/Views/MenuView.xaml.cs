using MvvmCross;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using Notenverwaltung.WPF.UI.Region;

namespace Notenverwaltung.WPF.UI.Views
{
    /// <summary>
    /// MenuView.
    /// </summary>
    /// <seealso cref="MvvmCross.Platforms.Wpf.Views.MvxWpfView{SimTuning.WPF.UI.ViewModels.MenuViewModel}" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [MvxWpfPresenter("MainWindowRegion", mvxViewPosition.NewOrExsist)]
    public partial class MenuView : MvxWpfView<Notenverwaltung.WPF.UI.ViewModels.MenuViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuView" /> class.
        /// </summary>
        public MenuView()
        {
            this.InitializeComponent();

            // when viewmodel already created
            if (Mvx.IoCProvider.TryResolve<Notenverwaltung.WPF.UI.ViewModels.MenuViewModel>(out var someViewModel))
            {
                ViewModel = someViewModel;

                return;
            }

            // creating viewmodel
            var _viewModelLoader = Mvx.IoCProvider.Resolve<IMvxViewModelLoader>();
            var request = new MvxViewModelInstanceRequest(typeof(Notenverwaltung.WPF.UI.ViewModels.MenuViewModel));
            request.ViewModelInstance = _viewModelLoader.LoadViewModel(request, null);
            ViewModel = request.ViewModelInstance as Notenverwaltung.WPF.UI.ViewModels.MenuViewModel;

            Mvx.IoCProvider.RegisterSingleton<Notenverwaltung.WPF.UI.ViewModels.MenuViewModel>(ViewModel);
        }
    }
}