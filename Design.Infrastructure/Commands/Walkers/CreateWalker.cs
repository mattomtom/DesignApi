using System;

namespace Design.Infrastructure.Commands.Walkers
{
    public class CreateWalker : ICommand
    {
        public Guid UserId { get; set; }

        public bool HaveVehicle { get; set; }

        public class WalkerVehicle
        {
            public string Brand { get; set; }
            public string Name { get; set; }
            public int Seats { get; set; }
        }
    }
}