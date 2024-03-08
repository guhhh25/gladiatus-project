using AutoMapper;
using Gladiatus.Application.Dtos;
using Gladiatus.Application.Interface;
using Gladiatus.Common;
using Gladiatus.Core.Entities;
using Gladiatus.Core.Interfaces.Services;


namespace MeuProjeto.Application.Services
{
    public class UserApiService : IUserApiService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserApiService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<Result<CreateUserDto>> CreateUser(CreateUserDto user)
        {
            var entity = _mapper.Map<ApplicationUser>(user);

            var newUser = await _userService.CreateUser(entity);

            if (newUser.Success)
            {
                return Result<CreateUserDto>.SuccessResult(user, "User created.");
            }
            else
            {
                return Result<CreateUserDto>.FailureResult("Failed to create a new user");
            }
        }
    }
}