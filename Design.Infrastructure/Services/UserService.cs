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
        private readonly IEncrypter _encrypter;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IEncrypter encrypter, IMapper mapper)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
            _mapper = mapper;
        }

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);
            
            return _mapper.Map<User,UserDto>(user);
        }

        public async Task LoginAsync(string email, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if (user == null)
            {
                throw new Exception("Invalid credentials");
            }
            
            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            if(user.Password == hash)
            {
                return;
            }
            throw new Exception("Invalid credentials");
        }

        public async Task RegisterAsync(Guid id, string email, string username, string password, string role)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception($"User with email: {email} already exisist.");
            }

            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            user = new User(Guid.NewGuid(),email, username, hash, role, salt);
            await _userRepository.AddAsync(user);
        }
    }
}