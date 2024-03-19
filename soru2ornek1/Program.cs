using soru2ornek1;
using System.Xml.Linq;

namespace soru2ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance: Bir nesnenin özellik ve davranışlarının başka bir nesne üzerinden kullanılmasını sağlar.

            Person person = new Person();

            person.ID = 1;

            Console.Write("Ad: ");
            person.Name = Console.ReadLine();

            Console.Write("Soyad: ");
            person.Surname = Console.ReadLine();

            Console.WriteLine($"\nPerson Info: {person.ID} - {person.Name} {person.Surname} - {person.Mail}\n");

            //----------------------------------------------
            Student student = new Student();

            student.ID = 2;

            Console.Write("Ad: ");
            student.Name = Console.ReadLine();

            Console.Write("Soyad: ");
            student.Surname = Console.ReadLine();

            student.StudentID = "12345";

            Console.WriteLine($"\nStudent Info: {student.ID}/{student.StudentID} - {student.Name} {student.Surname} - {student.Mail}\n");

            //----------------------------------------------
            Trainer trainer = new Trainer();

            trainer.ID = 3;

            Console.Write("Ad: ");
            trainer.Name = Console.ReadLine();

            Console.Write("Soyad: ");
            trainer.Surname = Console.ReadLine();

            trainer.PhoneNumber = "1234567890";

            Console.WriteLine($"\nTrainer Info: {trainer.ID} - {trainer.Name} {trainer.Surname} - {trainer.Mail} - {trainer.PhoneNumber}");
        }
    }

    // Main class
    class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Mail => Name.ToLower() + "." + Surname.ToLower() + "@hotmail.com";
    }

    // Derived class
    class Student : Person
    {
        public string StudentID { get; set; }
    }

    // Derived class
    class Trainer : Person
    {
        public string PhoneNumber { get; set; }
    }
}
