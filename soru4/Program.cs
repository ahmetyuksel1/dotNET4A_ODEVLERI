namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: 4- Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız. (While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız.)

            // Rastgele sayı oluşturuldu.
            Random rastgele = new Random();
            byte rastgeleSayi = (byte)rastgele.Next(1, 10);

            byte tahmin = 0, sayac = 1;

            try
            {
                while (tahmin != rastgeleSayi)
                {
                    // Kullanıcıdan sayı alındı.
                    Console.Write("1 ile 10 arasında bir sayı tuttum haydi tahmin et: ");
                    tahmin = byte.Parse(Console.ReadLine());

                    // Sayı kontrolü yapıldı. Ekrana yazdırıldı.
                    if (tahmin < rastgeleSayi)
                    {
                        Console.WriteLine($"Tahminin: {tahmin}, YUKARI!\n");
                    }
                    else if (tahmin > rastgeleSayi)
                    {
                        Console.WriteLine($"Tahminin: {tahmin}, AŞAĞI!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Tahminin: {tahmin}, DOĞRU!\n\n{sayac}. tahmininizde doğru sayıyı buldunuz.");
                        break;
                    }

                    sayac++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nHata:\n{ex}\n\nÇıkış Yapılıyor.");
            }
        }
    }
}
