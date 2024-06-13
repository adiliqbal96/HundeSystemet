using System;
using System.Security.Cryptography.X509Certificates;

namespace HundeSystemet
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            //Opret et dog objekt
            Dog dog = new Dog(1, "Buddy", Race.Labrador, 2020);
            Dog dog2 = new Dog(2, "Gonzo", Race.Labradoodle, 2019);


            //Opret member objekt
            Member member = new Member(1, "Jens", "Hovedgaden 10", new DateTime(1990,1,1), "20304050", "Jens@gmail.com");
            
            //Udskiver id + race fra enum dog virker
            //Console.WriteLine($"ID: {dog.ID}, Name: {dog.Name}, Race: {dog.Race}, YearOfBirth: {dog.YearOfBirth}");
            //Console.WriteLine($"ID: {member.ID}, Name: {member.Name}, Adresse: {member.Adresse} BirthDate: {member.BirthDate}, Phone: {member.Phone} Email: {member.Email}");

            //Tilføj hunden til medlemmet
            member.RegisterDog(dog);

            Console.WriteLine(member.ToString());
            Console.WriteLine(dog.ToString());
            Console.WriteLine($"Alder: {member.CalculateAge()}");
            Console.WriteLine($"Medlemskontingent: {member.CalculateMemberFee()}");

            //Opret et repository og tilføj medlemmet
            var repo = new MemberRepository();
            //repo.AddMember(member);

            //hent medlemmer fra repository og udskriv det
            var retrivedMember = repo.GetMember(1);
            Console.WriteLine(retrivedMember.ToString());


        }
    }
}
