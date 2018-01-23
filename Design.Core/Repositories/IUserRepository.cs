using Design.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Design.Core.Repositories
{
    public interface IUserRepository : IRepository
    {
        Task AddAsync(User user);
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task<IEnumerable<User>> GetAllAsync();
        Task RemoveAsync(Guid id);
        Task UpdateAsync(User user);
    }
}