using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242", true);
            
            Person gus = new Passenger("Augusto","Taño","1234567-8",@"bill.jpg",cog);
            Person gonza = new Passenger("Gonzalo","Barreiro","7894561-2",@"bill.jpg",cog);
            Person rafa = new Passenger("Rafael","Duran","4561275-8",@"bill.jpg",cog);

            Driver vale = new Driver("Valentina","Alvarez","9876543-2","Hola soy Vale","Suzuki Swift - Blue",@"claramente-no-es-bill.jpg",cog);
        }
    }
}
