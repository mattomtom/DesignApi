using System;
using System.Collections.Generic;
using Design.Core.Domain;

namespace Design.Core.Repositories
{
    public interface IWalkerRepository
    {
         Walker Get(Guid userId);
         IEnumerable<Walker> GetAll();
         void Add(Walker walker);
         void Update(Walker walker);
    }
}