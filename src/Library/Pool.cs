using System;
using System.Collections.Generic;

namespace Library
{
    public class PoolDriver : Driver 
    {
        protected int MaxPassengers {get; set;}

        public PoolDriver (string name, string surname, string CI, string bio, string vehicle, int maxPassengers, string image, CognitiveFace cog) : base(name, surname, CI, bio, vehicle, image, cog)
        {
            this.MaxPassengers = maxPassengers;
        }
    }
}