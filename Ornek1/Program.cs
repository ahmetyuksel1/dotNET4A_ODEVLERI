namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism: Bir nesnenin birden fazla biçime sahip olabilmesidir. Aynı isme sahip metotlar veya sınıfların farklı davranışlarda bulunabilmesidir.

            Operation operation = new Operation();
            operation.Message();

            Operation project = new Project();
            project.Message();

            Operation software = new Software();
            software.Message();
        }
    }

    // Class
    public class Operation
    {
        public virtual void Message()
        {
            Console.WriteLine("Operation is processing...\n");
        }
    }

    // Subclass
    class Project : Operation
    {
        public override void Message()
        {
            Console.WriteLine("Project is processing...\n");
        }
    }

    // Subclass
    class Software : Operation
    {
        public override void Message()
        {
            Console.WriteLine("Software is processing...");
        }
    }
}
