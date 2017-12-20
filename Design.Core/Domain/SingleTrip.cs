using System;
using System.Collections.Generic;

namespace Design.Core.Domain
{
    public class SingleTrip
    {
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public IEnumerable<WalkerNode> WalkerNodes { get; protected set; }
    }
}