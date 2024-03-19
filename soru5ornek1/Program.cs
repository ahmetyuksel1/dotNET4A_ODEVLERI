using System.Reflection;

namespace soru5ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            
            Console.Write("Surname: ");
            employee.Surname = Console.ReadLine();

            Console.Write("Age: ");
            employee.Age = int.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            employee.Salary = double.Parse(Console.ReadLine());

            employee.DisplayInfo();
        }
    }

    public class Employee
    {
        private string _name;
        private string _surname;
        private int _age;
        private double _salary;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 18 && value <= 65)
                    _age = value;
                else
                    throw new ArgumentException("Age must be between 18 and 65.");
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0 && value <= 1000000)
                    _salary = value;
                else
                    throw new ArgumentException("Salary cannot be negative or bigger than one million.");
            }
        }

        public void DisplayInfo()
        {
            Console.Clear();
            Console.WriteLine($"Full Name: {Name} {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary}TL");
        }
    }
}
