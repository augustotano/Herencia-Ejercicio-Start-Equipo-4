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

        //Revisa en base a la lista de pasajeros que obtiene de la futura clase viaje y los califica uno por uno con el mismo rate.
        public void RateAllPassengers(int rate)
        {
            foreach (var passenger in PassengerList)
            {
                passenger.ReceiveRate(rate);
            }
        }

    }
}