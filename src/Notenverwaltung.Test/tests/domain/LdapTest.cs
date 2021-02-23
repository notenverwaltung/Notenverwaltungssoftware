using MvvmCross;
using NUnit.Framework;

namespace Notenverwaltung.Test
{
    [TestFixture]
    public class LdapTest : MvxTest
    {
        private readonly string userName = "Meier";
        private Core.Services.ILdapService ldapService;

        [Test]
        public void AuthentifizierNutzerTest()
        {
            ldapService = Mvx.IoCProvider.Resolve<Core.Services.ILdapService>();

            ldapService.LoginUser(userName, "password");

            ldapService.GetDomainUsers();
            ldapService.GetDomainGroups();

            ldapService.GetUserRoles();
            ldapService.GetUserDomainGroups();
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();

            var ldapService = new Core.Services.LdapService();
            Ioc.RegisterSingleton<Core.Services.ILdapService>(ldapService);
        }
    }
}