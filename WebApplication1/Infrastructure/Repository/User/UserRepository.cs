using Gladiatus.Core.Entities;
using Gladiatus.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Gladiatus.Common;

namespace Gladiatus.Infrastructure.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Result<ApplicationUser>> AddUserAsync(ApplicationUser user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return Result<ApplicationUser>.SuccessResult(user, "Success");
            }
            catch (Exception ex)
            {
                return Result<ApplicationUser>.FailureResult("Failed to add an new user..");
            }
        }
    }
}