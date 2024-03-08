
using System.Threading.Tasks;
using Gladiatus.Common;
using Gladiatus.Core.Entities;
using Gladiatus.Core.Interfaces.Repository;
using Gladiatus.Core.Interfaces.Services;

namespace Gladiatus.Core.Repository
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<ApplicationUser>> CreateUser(ApplicationUser user)
        {
            var newUser = await _userRepository.AddUserAsync(user);

            if (newUser.Success)
            {
                return Result<ApplicationUser>.SuccessResult(user, "User created.");
            }
            else
            {
                return Result<ApplicationUser>.FailureResult("Failed to create a new user");
            }
        }
    }
}