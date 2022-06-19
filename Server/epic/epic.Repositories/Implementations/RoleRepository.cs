using epic.Entities;
using epic.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epic.Repositories.Implementations
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private AppDbContext dbContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }
        public RoleRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Task<Role> GetRolesById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsRole(int UserId, int RoleId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Role>> GetRolesByUserId(int userId)
        {
            
            var model = await(from userRoles in dbContext.UserRoles
                              join roles in dbContext.Roles
                              on userRoles.RoleId equals roles.Id
                              where userRoles.UserId == userId
                              select new Role
                              {
                                  Id = roles.Id,
                                  Name = roles.Name
                              }).ToListAsync();

            return model;
        }
    }
}
