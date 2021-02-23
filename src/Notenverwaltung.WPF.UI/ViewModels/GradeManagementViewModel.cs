using MvvmCross.Logging;
using MvvmCross.Navigation;
using Notenverwaltung.Core.Enums;
using Notenverwaltung.Core.Services;
using System.Threading.Tasks;

namespace Notenverwaltung.WPF.UI.ViewModels
{
    public class GradeManagementViewModel : Notenverwaltung.Core.ViewModels.GradeManagementViewModel
    {
        private readonly IUserPermissions _userPermissions;

        public bool CanPrintPermission
        {
            get => _userPermissions.GetDeletePermission(ModuleType.GradeManagement);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu" /> class.
        /// </summary>
        /// <param name="logProvider">The log provider.</param>
        /// <param name="navigationService">The navigation service.</param>
        /// <param name="messenger">The messenger.</param>
        public GradeManagementViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserPermissions userPermissions)
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