using epic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epic.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        //Task<IEnumerable<User>> GetUsers();
        //Task<User> GetUserById(int id);
        //void Delete(User user);
        //Task Add(User user);
        Task Update(User user);
        Task<User> Exists(string username);
        //User Exists(string username);
        //Task<bool> Exists(string email, string password);
        Task<bool> Exists(string name, int Id);
        Task<User> GetUserByUserName(string? username);
    }
}
