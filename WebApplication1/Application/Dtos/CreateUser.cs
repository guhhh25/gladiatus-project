﻿namespace Gladiatus.Application.Dtos
{
    public class CreateUserDto
    {
        public required string UserName { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

    }
}
