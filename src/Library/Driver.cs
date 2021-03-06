using System;

namespace Library
{
    public class Driver : Person
    {

        public string Vehicle {get; set;}
        public string Bio {get; set;}

        public Driver (string name, string surname, string CI, string bio, string vehicle, string image, CognitiveFace cog) : base(name, surname, CI, image, cog)
        {
            this.Bio = bio;
            this.Vehicle = vehicle;
            this.FoundFace(cog);
        }

        public override void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                    new SendTwitt().Send(this.Bio, this.Image);
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
            {
                Console.WriteLine("No Face Found");
            }
        }
    }
}