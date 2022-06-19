using epic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epic.Repositories.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        //Task<IEnumerable<Role>> GetRoles();

        Task<Role> GetRolesById(int userId);

        //Task AddRole(UserRole role);

        //Task UpdateRole(UserRole role);

        //Task<bool> SaveChanges();

        //Task<int> SaveChangesAsync();

        Task<bool> ExistsRole(int UserId, int RoleId);

        //void DeleteRole(UserRole role);

        Task<List<Role>> GetRolesByUserId(int userId);
    }
}
