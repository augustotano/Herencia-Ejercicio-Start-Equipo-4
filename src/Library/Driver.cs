using System;

namespace Library
{
    public class Driver : Person
    {

        public string Bio {get; set;}
        public string Vehicle {get; set;}

        public Driver (string name, string surname, string CI, string bio, string vehicle) : base(name, surname, CI)
        {
            this.Vehicle = vehicle;
            this.Bio = bio;
        }

        public virtual void RatePassenger(Passenger passenger, int rate)
        {
            if (rate >= 1 && rate <= 5)
            {
                passenger.Rating = (passenger.Rating + rate) / 2;
            }
        }
            

    }
}