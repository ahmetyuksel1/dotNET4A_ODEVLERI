namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism: Bir nesnenin birden fazla biçime sahip olabilmesidir. Aynı isme sahip metotlar veya sınıfların farklı davranışlarda bulunabilmesidir.

            Quote quote = new Quote();
            quote.Message();

            Quote quote2 = new Quote2();
            quote2.Message();

            Quote quote3 = new Quote3();
            quote3.Message();
        }
    }

    // Class
    public class Quote
    {
        public virtual void Message()
        {
            Console.WriteLine("Damnant quod non intelligunt.\n");
        }
    }

    public class Quote2 : Quote
    {
        public override void Message()
        {
            Console.WriteLine("Be aware of a old man in a profession where men usually die young.\n");
        }
    }

    public class Quote3 : Quote
    {
        public override void Message()
        {
            Console.WriteLine("Öl, söz verme. Öl, sözünden dönme.");
        }
    }
}
