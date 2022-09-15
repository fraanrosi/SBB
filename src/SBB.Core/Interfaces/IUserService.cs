using SBB.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBB.Core.Interfaces
{
    internal interface IUserService
    {
        Task<User> AddUser(User user);
        Task<User> GetUser(int id);
        Task<User> SetUser(User user);
        Task DeleteUser(int id);
    }
}
