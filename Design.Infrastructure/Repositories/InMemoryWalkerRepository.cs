using System;
using System.Collections.Generic;
using System.Linq;
using Design.Core.Domain;
using Design.Core.Repositories;

namespace Design.Infrastructure.Repositories
{
    public class InMemoryWalkerRepository : IWalkerRepository
    {
        private static ISet<Walker> _walker = new HashSet<Walker>();

        public void Add(Walker walker)
        {
            _walker.Add(walker);
        }

        public Walker Get(Guid userId) =>
            _walker.Single(x => x.UserId == userId);

        public IEnumerable<Walker> GetAll() =>
            _walker;

        public void Update(Walker walker)
        {
            //TODO
        }
    }
}