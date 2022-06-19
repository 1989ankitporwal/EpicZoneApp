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
    public class UserRepository : Repository<User>, IUserRepository
    {
        private AppDbContext dbContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }
        public UserRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public async Task<User> Exists(string username)
        {
            //throw new NotImplementedException();
            User user = await dbContext.Users.FirstOrDefaultAsync(x => x.UserName == username 
                                            || x.Email == username);
            
            return user;
        }

        //public Task<bool> Exists(string email, string password)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<bool> Exists(string name, int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByUserName(string? username)
        {
            if (username == null) return null;
            var user = await dbContext.Users.SingleOrDefaultAsync(u => u.UserName == username);
            return user;
        }

        public async Task Update(User user)
        {
            dbContext.Set<User>().Update(user);
            await dbContext.SaveChangesAsync();
        }
    }
}
