namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

            // Mükemmel Sayı: Kendi bölenlerinin toplamı, iki katına eşit olan sayılara denir.

            /*
             * Algoritma: 
             * 1) Başla.
             * 2) Kullanıcıdan bir sayı al.
             * 3) Sayının mükemmel sayı olma durumunu kontrol et.
             * 4) Mükemmel sayıysa veya mükemmel sayı değilse ekrana yaz.
             * 5) Bitir.
             */

            decimal sayi = 0;

            Console.WriteLine("Mükemmel Sayı Arayan Program (Çıkış: Harf Girişi)\n");

            try
            {
                while (sayi.GetType().ToString() == "System.Decimal")
                {
                    Console.Write("Bir sayı giriniz: ");
                    sayi = decimal.Parse(Console.ReadLine());

                    if (sayi > 9999999)
                    {
                        Console.WriteLine("Geçersiz sayı. Program sonlandırıldı.");
                        break;
                    }

                    decimal toplam = 0;

                    for (int i = 1; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            toplam = toplam + i;
                        }
                    }

                    if (toplam == sayi)
                    {
                        Console.WriteLine($"{sayi} sayısı, mükemmel sayıdır.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{sayi} sayısı, mükemmel sayı değildir.\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nHata:\n{ex}\n\nÇıkış Yapılıyor.");
            }
        }
    }
}
