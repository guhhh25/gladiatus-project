using Gladiatus.Common;
using Gladiatus.Core.Entities;

namespace Gladiatus.Core.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<Result<ApplicationUser>> AddUserAsync(ApplicationUser user);
    }
}
