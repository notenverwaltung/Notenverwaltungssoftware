using MvvmCross.Logging;
using MvvmCross.Navigation;
using Notenverwaltung.Core;
using Notenverwaltung.Core.Enums;
using Notenverwaltung.Core.Services;
using System.Threading.Tasks;

namespace Notenverwaltung.WPF.UI.ViewModels
{
    public class StudentManagementViewModel : Notenverwaltung.Core.ViewModels.StudentManagementViewModel
    {
        private readonly IUserPermissions _userPermissions;

        public bool CanDeletePermission
        {
            get => _userPermissions.GetDeletePermission(ModuleType.StudentManagement);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu" /> class.
        /// </summary>
        /// <param name="logProvider">The log provider.</param>
        /// <param name="navigationService">The navigation service.</param>
        /// <param name="messenger">The messenger.</param>
        public StudentManagementViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserPermissions userPermissions)
            : base(logProvider, navigationService)
        {
            this._userPermissions = userPermissions;
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