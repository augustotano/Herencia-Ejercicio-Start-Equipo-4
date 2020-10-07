using System;

namespace Library
{
    public abstract class Person
    {
        public string Name {get; set;}
        public string Surname {get; set;}
        public string CI {get; set;}
        public int Rating {get; set;}

        public Person (string name, string surname, string CI)
        {
            this.Name = name;
            this.Surname = surname;
            this.CI = CI;
            this.Rating = 0;
        }

    }
}