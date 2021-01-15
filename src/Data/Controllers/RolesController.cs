using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public class RolesController : IRolesController
    {
        private readonly DatabaseContext _context;

        public RolesController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Role> DeleteRole(long id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role == null)
            {
                return null;
            }

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();

            return role;
        }

        public async Task<Role> GetRole(long id)
        {
            var role = await _context.Roles.FindAsync(id);

            if (role == null)
            {
                return null;
            }

            return role;
        }

        public async Task<IEnumerable<Role>> GetRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> PostRole(Role role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();

            return role;
        }

        public async Task PutRole(long id, Role role)
        {
            if (id != role.Id)
            {
                return;
            }

            _context.Entry(role).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleExists(id))
                {
                    return;
                }
                else
                {
                    throw;
                }
            }

            return;
        }

        private bool RoleExists(long id)
        {
            return _context.Roles.Any(e => e.Id == id);
        }
    }
}