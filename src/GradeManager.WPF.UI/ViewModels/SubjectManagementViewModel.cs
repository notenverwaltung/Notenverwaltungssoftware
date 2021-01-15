using Data.Controllers;
using Data.Models;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;

namespace GradeManager.WPF.UI.ViewModels
{
    public class SubjectManagementViewModel : GradeManager.Core.ViewModels.SubjectManagementViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Menu" /> class.
        /// </summary>
        /// <param name="logProvider">The log provider.</param>
        /// <param name="navigationService">The navigation service.</param>
        /// <param name="messenger">The messenger.</param>
        public SubjectManagementViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, ISubjectsController subjectsController)
            : base(logProvider, navigationService)
        {
            _subjectsController = subjectsController;
        }

        #region Methods

        private readonly ISubjectsController _subjectsController;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>Initilisierung.</returns>
        public override async Task Initialize()
        {
            await base.Initialize();

            SubjectItems = new ObservableCollection<Subject>();
            var subjects = await _subjectsController.GetSubjects();
            foreach (var subject in subjects.OrderBy(i => i.Name))
            {
                SubjectItems.Add(subject);
            }
            _subjectItemsView = CollectionViewSource.GetDefaultView(SubjectItems);
            _subjectItemsView.Filter = SubjectItemsFilter;
        }

        /// <summary>
        /// Prepares this instance. called after construction.
        /// </summary>
        public override void Prepare()
        {
            base.Prepare();
        }

        private bool SubjectItemsFilter(object obj)
        {
            if (string.IsNullOrWhiteSpace(_searchKeyword))
            {
                return true;
            }

            return obj is Subject item
                   && item.Name.ToLower().Contains(_searchKeyword!.ToLower());
        }

        #endregion Methods

        #region Values

        private string _searchKeyword;
        private int _selectedIndex;
        private Subject _selectedItem;
        private ICollectionView _subjectItemsView;

        public string SearchKeyword
        {
            get => _searchKeyword;
            set
            {
                this.SetProperty(ref _searchKeyword, value);
                _subjectItemsView.Refresh();
            }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                this.SetProperty(ref _selectedIndex, value);
            }
        }

        public Subject SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (value == null || value.Equals(_selectedItem)) return;

                this.SetProperty(ref _selectedItem, value);
            }
        }

        public ObservableCollection<Subject> SubjectItems { get; protected set; }

        #endregion Values
    }
}