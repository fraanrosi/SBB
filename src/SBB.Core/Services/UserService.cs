using SBB.Core.Entities;
using SBB.Core.Interfaces;

namespace SBB.Core.Services
{
    internal class UserService : IUserService
    {
        private readonly IRepository<User> _UserRepository;        

        public UserService(IRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task<User> AddUser(User user)
        {
            var result = await _UserRepository.GetByIdAsync(user.Id);
            result ??= await _UserRepository.AddAsync(user);

            return result;
        }

        public async Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> SetUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
