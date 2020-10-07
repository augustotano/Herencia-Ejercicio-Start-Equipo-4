using System;

namespace Library
{
    public class Passenger : Person 
    {
        public Passenger (string name, string surname, string CI) : base(name, surname, CI)
        {
        }

        public void RateDriver (Driver driver, int rate)
        {
            if (rate >= 1 && rate <= 5)
            {
                driver.Rating = (driver.Rating + rate) / 2;
            }
        }    

    }
}