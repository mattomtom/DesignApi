using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Design.Core.Domain;

namespace Design.Core.Repositories
{
    public interface IWalkerRepository : IRepository
    {
         Task<Walker> GetAsync(Guid userId);
         Task<IEnumerable<Walker>> GetAllAsync();
         Task AddAsync(Walker walker);
         Task UpdateAsync(Walker walker);
    }
}