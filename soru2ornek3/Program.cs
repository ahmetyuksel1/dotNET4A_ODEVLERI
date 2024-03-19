namespace soru2ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance: Bir nesnenin özellik ve davranışlarının başka bir nesne üzerinden kullanılmasını sağlar.

            Process process = new Process();
            process.Status();

            Nock nock = new Nock();
            nock.NockArrow();

            Draw draw = new Draw();
            draw.DrawArrow();

            Loose loose = new Loose();
            loose.LooseArrow();
        }
    }

    public class Process
    {
        public void Status()
        {
            Console.WriteLine("Archer!\n");
        }
    }

    public class Nock : Process
    {
        public void NockArrow()
        {
            Console.WriteLine("Nock!");
        }
    }

    public class Draw : Process
    {
        public void DrawArrow()
        {
            Console.WriteLine("Draw!");
        }
    }

    public class Loose : Process
    {
        public void LooseArrow()
        {
            Console.WriteLine("Loose!");
        }
    }
}
