using MvvmCross.Commands;
using MvvmCross.Core;
using MvvmCross.Navigation;
using MvvmCross.Tests;
using NUnit.Framework;

namespace Notenverwaltung.Test
{
    [TestFixture]
    public class ViewModelTest : MvxTest
    {
        [Test]
        public void ClassManagementViewModelTest()
        {
            var vm = Ioc.IoCConstruct<WPF.UI.ViewModels.ClassManagementViewModel>();
            //vm.SomeCommand.ListenForRaiseCanExecuteChanged();

            //Assert.AreEqual(vm.SomeCommand.RaisedCanExecuteChanged(), true);
        }

        [Test]
        public void GradeManagementViewModelTest()
        {
            var vm = Ioc.IoCConstruct<WPF.UI.ViewModels.GradeManagementViewModel>();
            //vm.SomeCommand.ListenForRaiseCanExecuteChanged();

            //Assert.AreEqual(vm.SomeCommand.RaisedCanExecuteChanged(), true);
        }

        [Test]
        public void MenuViewModelTest()
        {
            var vm = Ioc.IoCConstruct<WPF.UI.ViewModels.MenuViewModel>();
            //vm.SomeCommand.ListenForRaiseCanExecuteChanged();

            //Assert.AreEqual(vm.SomeCommand.RaisedCanExecuteChanged(), true);
        }

        [Test]
        public void SettingsViewModelTest()
        {
            var vm = Ioc.IoCConstruct<WPF.UI.ViewModels.SettingsViewModel>();
            //vm.SomeCommand.ListenForRaiseCanExecuteChanged();

            //Assert.AreEqual(vm.SomeCommand.RaisedCanExecuteChanged(), true);
        }

        [Test]
        public void StudentManagementViewModelTest()
        {
            var vm = Ioc.IoCConstruct<WPF.UI.ViewModels.StudentManagementViewModel>();
            //vm.SomeCommand.ListenForRaiseCanExecuteChanged();

            //Assert.AreEqual(vm.SomeCommand.RaisedCanExecuteChanged(), true);
        }

        [Test]
        public void SubjectManagementViewModelTest()
        {
            var vm = Ioc.IoCConstruct<WPF.UI.ViewModels.SubjectManagementViewModel>();
            //vm.SomeCommand.ListenForRaiseCanExecuteChanged();

            //Assert.AreEqual(vm.SomeCommand.RaisedCanExecuteChanged(), true);
        }

        [Test]
        public void TeacherManagementViewModelTest()
        {
            var vm = Ioc.IoCConstruct<WPF.UI.ViewModels.TeacherManagementViewModel>();
            //vm.SomeCommand.ListenForRaiseCanExecuteChanged();

            //Assert.AreEqual(vm.SomeCommand.RaisedCanExecuteChanged(), true);
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();

            // for navigation parsing
            Ioc.RegisterSingleton<IMvxStringToTypeParser>(new MvxStringToTypeParser());

            // for navigation
            MvxNavigationService navigationService = new MvxNavigationService(null, null)
            {
                ViewDispatcher = MockDispatcher,
            }
            ;
            navigationService.LoadRoutes(new[] { typeof(WPF.UI.ViewModels.ClassManagementViewModel).Assembly });
            Ioc.RegisterSingleton<IMvxNavigationService>(navigationService);

            // for commands
            var commandHelper = new MvxUnitTestCommandHelper();
            Ioc.RegisterSingleton<IMvxCommandHelper>(commandHelper);

            // for theme
            var themeService = new WPF.UI.Services.ThemeService();
            Ioc.RegisterSingleton<WPF.UI.Services.IThemeService>(themeService);
        }
    }
}