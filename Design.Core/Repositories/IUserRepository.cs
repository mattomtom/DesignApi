using Design.Core.Domain;
using System;
using System.Collections.Generic;

namespace Design.Core.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(Guid id);
        User Get(string email);
        IEnumerable<User> GetAll();
        void Remove(Guid id);
        void Update(User user);
    }
}