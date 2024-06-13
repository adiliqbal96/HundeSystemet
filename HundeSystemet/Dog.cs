using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeSystemet
{

    public enum Race
    {
        //Enum til forskellige hunde racer
        Labrador,
        Husky,
        Rotweiler,
        Labradoodle,
    }
    internal class Dog
    {
        //Properties
        public int ID { get; set; }

        public string Name { get; set; }

        public Race Race { get; set; }

        public int YearOfBirth { get; set; }

        //Konstruktør
        public Dog(int id, string name, Race race, int yearOfBirth)
        {
            this.ID = id;
            this.Name = name;
            this.Race = race;
            this.YearOfBirth = yearOfBirth;


        }
        //opgave2
        // ToString metode for at give en tekstbeskrivelse af hunden
        public override string ToString()
        {
            return $"Dog(Id: {ID}, Name: {Name}, Race: {Race}, YearOfBirth: {YearOfBirth})";
        }
    }
}

