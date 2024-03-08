using Gladiatus.Application.Dtos;
using Gladiatus.Common;
using Gladiatus.Core.Entities;

namespace Gladiatus.Application.Interface
{
    public interface IUserApiService
    {
        Task<Result<CreateUserDto>> CreateUser(CreateUserDto user);
    }
}
