using Data.Enums;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using Notenverwaltung.Core;
using Notenverwaltung.Core.Services;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading.Tasks;

namespace Notenverwaltung.WPF.UI.ViewModels
{
    public class SplashScreenViewModel : Notenverwaltung.Core.ViewModels.SplashScreenViewModel
    {
        private readonly ILdapService _ldapService;
        private readonly IUserPermissions _userPermissions;
        private string _loginName;

        public string LoginName
        {
            get => _loginName;
            set => SetProperty(ref _loginName, value);
        }

        public IMvxAsyncCommand NavigateCommand { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu" /> class.
        /// </summary>
        /// <param name="logProvider">The log provider.</param>
        /// <param name="navigationService">The navigation service.</param>
        /// <param name="messenger">The messenger.</param>
        public SplashScreenViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserPermissions userPermissions, ILdapService ldapService)
            : base(logProvider, navigationService)
        {
            this._userPermissions = userPermissions;
            this._ldapService = ldapService;

            NavigateCommand = new MvxAsyncCommand(() => NavigationService.Navigate<MainWindowViewModel>());

            LoginName = Environment.UserName;
            _ldapService.SetUser(Environment.UserName);
            _userPermissions.SetRole(_ldapService.GetUserRoles().FirstOrDefault());

            // TODO: only for testing
            Task.Run(async () =>
            {
                await Task.Delay(3000);
                NavigateCommand.Execute();
                await NavigationService.Close(this);
            });
        }

        #region Methods

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>Initilisierung.</returns>
        public override Task Initialize()
        {
            return base.Initialize();
        }

        /// <summary>
        /// Prepares this instance. called after construction.
        /// </summary>
        public override void Prepare()
        {
            base.Prepare();
        }

        #endregion Methods
    }
}