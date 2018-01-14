using System;
using System.Threading.Tasks;
using AutoMapper;
using Design.Core.Domain;
using Design.Core.Repositories;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);
            
            return _mapper.Map<User,UserDto>(user);
        }

        public async Task RegisterAsync(Guid id, string email, string username, string password, string role)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception($"User with email: {email} already exisist.");
            }

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, username, password, role, salt);
            await _userRepository.AddAsync(user);
        }
    }
}