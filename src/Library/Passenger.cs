using System;

namespace Library
{
    public class Passenger : Person 
    {
        public Passenger (string name, string surname, string CI, string image, CognitiveFace cog) : base(name, surname, CI, "", image, cog)
        {
        }

        public override void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                new SendTwitt().Send(this.Name, this.Image);
            }
            else
            {
                Console.WriteLine("No Face Found");
            }
        }  
    }
}