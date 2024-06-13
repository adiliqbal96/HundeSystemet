using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HundeSystemet
{
    internal class Member
    {
        //properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Dog> Dogs { get; set; } = new List<Dog>();

        //konstruktør
        public Member(int iD, string name, string adresse, DateTime birthDate, string phone, string email)
        {
            ID = iD;
            Name = name;
            Adresse = adresse;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
        }

        //Metode til at tilføje en hund til et medlem
        public void RegisterDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        //Beregn medlemmets alder
        public int CalculateAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        // Beregner kontingentet for medlemmet
        public decimal CalculateMemberFee()
        {
            // Implementer forretningslogik for at beregne medlemskontingent
            return 100m; // Pladsholder værdi
        }

        public override string ToString()
        {
            return $"Member(Id: {ID}, Name: {Name}, Address: {Adresse}, BirthDate: {BirthDate}, Phone: {Phone}, Email: {Email})";


        }
    }
}
























//    // Tilføj en hund til medlemmet
//    public void AddDog(Dog dog)
//    {
//        Dogs.Add(dog);
//    }

//    // Fjern en hund fra medlemmet baseret på hundens id
//    public void RemoveDog(int dogId)
//    {
//        Dogs.RemoveAll(dog => dog.Id == dogId);
//    }
//}
