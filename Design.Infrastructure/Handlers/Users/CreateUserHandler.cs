using System;
using System.Threading.Tasks;
using Design.Infrastructure.Commands;
using Design.Infrastructure.Commands.Users;
using Design.Infrastructure.Services;

namespace Design.Infrastructure.Handlers.Users
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserService _userService;
        
        public CreateUserHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task HandleAsync(CreateUser command)
        {
            await _userService.RegisterAsync(Guid.NewGuid(), command.Email, 
                command.Username, command.Password, command.Role);
        }
    }
}