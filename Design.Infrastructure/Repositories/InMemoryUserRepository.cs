using System;
using System.Collections.Generic;
using System.Linq;
using Design.Core.Domain;
using Design.Core.Repositories;

namespace Design.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>
        {
            new User("user1@email.com","user1","secret1","salt1"),
            new User("user2@email.com","user2","secret2","salt2"),
            new User("user3@email.com","user3","secret3","salt3")
        };

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid id)
            => _users.Single(x => x.Id == id);

        public IEnumerable<User> GetAll()
            => _users;

        public User Get(string email)
            => _users.Single(x => x.Email == email.ToLowerInvariant());

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
        }
    }
}