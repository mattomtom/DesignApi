using System;
using System.Threading.Tasks;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public interface IUserService
    {
        Task<UserDto> GetAsync(string email);
        Task RegisterAsync(Guid userId, string email,string username, string password, string role);
    }
}