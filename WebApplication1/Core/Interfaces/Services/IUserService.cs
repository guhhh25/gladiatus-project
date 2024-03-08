using Gladiatus.Common;
using Gladiatus.Core.Entities;

namespace Gladiatus.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<Result<ApplicationUser>> CreateUser(ApplicationUser user);
    }
}
