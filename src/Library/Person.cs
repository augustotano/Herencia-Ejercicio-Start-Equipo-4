using System;

namespace Library
{
    public abstract class Person
    {
        public string Name {get; set;}
        public string Surname {get; set;}
        public string CI {get; set;}
        public int Rating {get; set;}
        /*
        TrueRate representa la suma de todas las calificaciones, se utiliza para obtener un promedio en conjunto
        con Travels para crear un Rating más realista.
        */
        public int TrueRate {get; set;}
        public int Travels {get; set;}
        public string Image {get; set; }

        public Person (string name, string surname, string CI, string image, CognitiveFace cog)
        {
            this.Name = name;
            this.Surname = surname;
            this.CI = CI;
            this.Rating = 0;
            this.TrueRate = 0;
            this.Travels = 0;
            this.Image = image;
            cog.Recognize(image);
        }

        /*
        Para mantener encapsulamiento, ReceiveRate acepta un rate como parametro para cambiar el Rating del propio objeto.
        Al ser el mismo metodo tanto como para conductores como para pasajeros, se vuelve un metodo de la clase person.
        */
        public void ReceiveRate (int rate)
        {
            if (rate >= 1 && rate <= 5)
            {
                this.TrueRate += rate;
                this.Rating = (this.TrueRate) / this.Travels;
            }
        }
        public abstract void FoundFace(CognitiveFace cog);

    }
}