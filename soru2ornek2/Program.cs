namespace soru2ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance: Bir nesnenin özellik ve davranışlarının başka bir nesne üzerinden kullanılmasını sağlar.

            Animal animal = new Animal();
            Console.Write("Animal is "); animal.Eat();

            Monkey monkey = new Monkey();
            Console.Write("Monkey is "); monkey.Jump();

            Duck duck = new Duck();
            Console.Write("Duck is "); duck.Swim();
        }
    }

    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
        
        public void Walk()
        {
            Console.WriteLine("walking...");
        }

        public void Sleep()
        {
            Console.WriteLine("sleeping...");
        }

    }
    public class Monkey : Animal
    {
        public void Jump()
        {
            Console.WriteLine("jumping...");
        }
    }
    public class Duck : Animal
    {
        public void Swim()
        {
            Console.WriteLine("swimming...");
        }
    }
}
