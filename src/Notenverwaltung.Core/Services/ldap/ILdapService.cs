using Data.Enums;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;

namespace Notenverwaltung.Core.Services
{
    public interface ILdapService
    {
        List<Principal> GetDomainGroups();

        List<UserPrincipal> GetDomainUsers();

        List<Principal> GetUserDomainGroups();

        List<RoleType> GetUserRoles();

        void SetUser(string userName);
    }
}