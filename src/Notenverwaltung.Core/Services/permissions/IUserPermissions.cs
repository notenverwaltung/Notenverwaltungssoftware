using Data.Enums;
using Notenverwaltung.Core.Enums;

namespace Notenverwaltung.Core
{
    public interface IUserPermissions
    {
        bool GetDeletePermission(ModuleType module);

        bool GetLookPermission(ModuleType module);

        bool GetModifyPermission(ModuleType module);

        bool GetPrintPermission(ModuleType module);

        RoleType GetRole();

        void SetRole(RoleType role);
    }
}