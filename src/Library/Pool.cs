using System;
using System.Collections.Generic;

namespace Library
{
    public class PoolDriver : Driver 
    {

        protected int MaxPassengers {get; set;}
        protected Passenger[] PassengerList {get; set;}

        public PoolDriver (string name, string surname, string CI, string bio, string vehicle, int maxPassengers) : base(name, surname, CI, bio, vehicle)
        {
            this.MaxPassengers = maxPassengers;
        }

        public override void RatePassenger(Passenger passenger, int rate)
        {

            if (rate >= 1 && rate <= 5)
            {
                passenger.Rating = (passenger.Rating + rate) / 2;
            }
        }

    }
}