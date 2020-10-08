using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Person gus = new Passenger("Augusto","Taño","1234567-8","@bill.jpg");
            Person gonza = new Passenger("Gonzalo","Barreiro","7894561-2","@bill.jpg");
            Person rafa = new Passenger("Rafael","Duran","4561275-8","@bill.jpg");

            Driver vale = new PoolDriver("Valentina","Alvarez","5231590-4","Hola soy Vale, recien me uni a UcuRide","Citroen C3 - Rojo",3,"@bill2.jpg");
            
            CognitiveFace cog = new CognitiveFace("a36648d3c5134ab692acd35605d491f7", true);
            cog.Recognize(vale.Image);
            CorrectImage.FoundDriversFace(cog, vale);

            //todas las imagenes son las mismas si quieren vemos de usar el barco para que de error 
            cog.Recognize(gus.Image);
            CorrectImage.FoundPassangersFace(cog, gus);
            cog.Recognize(gonza.Image);
            CorrectImage.FoundPassangersFace(cog,gonza);
            cog.Recognize(rafa.Image);
            CorrectImage.FoundPassangersFace(cog, rafa);
            
            //faltan los puntajes
           
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
