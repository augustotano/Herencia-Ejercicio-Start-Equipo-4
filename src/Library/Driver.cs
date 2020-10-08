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
    }
}