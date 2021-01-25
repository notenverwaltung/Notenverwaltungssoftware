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

            LoginCommand = new MvxAsyncCommand(Login);
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

        /// <summary>
        /// Login.
        /// </summary>
        private async Task Login()
        {
            _ldapService.LoginUser(LoginName, Password);
            var roles = _ldapService.GetUserRoles();
            _userPermissions.SetRole(roles.FirstOrDefault());

            await NavigationService.Navigate<MainWindowViewModel>().ConfigureAwait(true);
            await NavigationService.Close(this).ConfigureAwait(true);
        }

        #endregion Methods

        #region Values

        private readonly ILdapService _ldapService;
        private readonly IUserPermissions _userPermissions;
        private string _loginName;

        private string _password;

        public IMvxAsyncCommand LoginCommand { get; private set; }

        public string LoginName
        {
            get => _loginName;
            set => SetProperty(ref _loginName, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        #endregion Values
    }
}