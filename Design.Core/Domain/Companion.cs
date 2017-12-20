using System;

namespace Design.Core.Domain
{
    public class Companion
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Node Address { get; protected set; }   
    }
}