using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface IRolesController
    {
        Task<Role> DeleteRole(long id);

        Task<Role> GetRole(long id);

        Task<IEnumerable<Role>> GetRoles();

        Task<Role> PostRole(Role role);

        Task PutRole(long id, Role role);
    }
}