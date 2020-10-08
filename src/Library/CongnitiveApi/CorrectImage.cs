using System;
using System.Drawing;

namespace Library
{
    public class CorrectImage
    {
        //aca es donde usa los metodos, le pase por parametro el tipo para diferenciar, pero lo podriamos mejorar, polimorfismo maybe
        //lo vemos luego, cuando lo manda lo que postea es en el caso del que maneja la bio y su foto y en el pasajero el nombre y la 
        //foto no me acuerdo de que era lo que pedia la letra ---Vale 
        public static void FoundDriversFace(CognitiveFace cog, Driver driver)
        {
            SendTwitt sendTwitt = new SendTwitt();
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                    sendTwitt.Send(driver.Bio, driver.Image);
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }

        public static void FoundPassangersFace(CognitiveFace cog, Person passanger)
        {
            SendTwitt sendTwitt = new SendTwitt();
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                sendTwitt.Send(passanger.Name, passanger.Image);
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)"); 
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }
    }
}
