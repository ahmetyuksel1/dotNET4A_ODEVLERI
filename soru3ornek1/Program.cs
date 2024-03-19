namespace soru3ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Type: Birden çok veri türüyle çalışan sınıf, yapı veya yöntemlerin oluşturulmasını sağlar.
            // Belirli bir türü belirtmek yerine, çalışma zamanında tanımlanan bir türü kabul eden ve işleyen bir yapıdır.

            GenericClass<int> genericClass1 = new GenericClass<int>();

            genericClass1.Method(3466);

            Console.WriteLine(genericClass1.Value);

            //-----------------------------------------------------------------------------------
            
            GenericClass<string> genericClass2 = new GenericClass<string>();

            genericClass2.Method("Hello World!");

            Console.WriteLine(genericClass2.Value);
        }
    }

    public class GenericClass<T>
    {
        public T Value;

        public void Method(T param)
        {
            Value = param;
        }
    }
}
