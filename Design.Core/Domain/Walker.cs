using System;
using System.Collections.Generic;

namespace Design.Core.Domain
{
    public class Walker
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<SingleTrip> SingleRoutes { get; protected set; }
    }
}