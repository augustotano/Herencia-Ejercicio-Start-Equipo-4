using System;

namespace Library
{
    public class Passenger : Person 
    {
        //Esta clase queda triste y sin nada, por ahora no se me ocurre que ponerle pero puede que surja algo. --augusto
        //Le sume lo de las caras aca tambien, en todos lados la verdad jaja --vale 
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