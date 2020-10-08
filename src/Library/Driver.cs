using System;

namespace Library
{
    public class Driver : Person
    {

        public string Bio {get; set;}
        public string Vehicle {get; set;}

        //le sume una imagen para poder hacer lo de las caras --- vale
        public Driver (string name, string surname, string CI, string bio, string vehicle, string image) : base(name, surname, CI, image)
        {
            this.Vehicle = vehicle;
            this.Bio = bio;
        }   
    }
}