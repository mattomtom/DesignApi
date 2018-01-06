using System;
using System.Collections.Generic;
using Design.Core.Domain;

namespace Design.Infrastructure.DTO
{
    public class WalkerDto
    {
        public Guid Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Route> Routes { get; set; }
    }
}