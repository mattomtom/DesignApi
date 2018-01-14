using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Design.Core.Domain;
using Design.Core.Repositories;

namespace Design.Infrastructure.Repositories
{
    public class InMemoryWalkerRepository : IWalkerRepository
    {
        private static ISet<Walker> _walker = new HashSet<Walker>();

        public async Task AddAsync(Walker walker)
        {
            _walker.Add(walker);
            await Task.CompletedTask;
        }

        public async Task<Walker> GetAsync(Guid userId) =>
            await Task.FromResult(_walker.SingleOrDefault(x => x.UserId == userId));

        public async Task<IEnumerable<Walker>> GetAllAsync() =>
            await Task.FromResult(_walker);

        public async Task UpdateAsync(Walker walker)
        {
            //TODO
            await Task.CompletedTask;
        }
    }
}