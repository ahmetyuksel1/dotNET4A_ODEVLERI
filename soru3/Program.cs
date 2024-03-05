namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

            Console.WriteLine("\"Do While\" ve \"While\" dögüsü nedir?\n\n" +
                "1) 'Do While' ile 'do' scope'u içerisinde yapılması istenilen işlemleri gerçekleştiren kodlar yazılır, daha sonra 'while' kısmında şart ya da şartlar belirtilir.\n\n" +
                "2) 'While' ile önce şart ya da şartlar belirtilir daha sonra ise istenilen işlemleri gerçekleştiren kodlar yazılır.");

            try
            {
                Console.Write("\nHangi programı çalıştırmak istersiniz (true: DO WHILE, false: WHILE): ");
                bool calistirilacakProgram = bool.Parse(Console.ReadLine());

                if (calistirilacakProgram)
                {
                    // DO WHILE ÖRNEĞİ: Tek/Çift Sayı Kontrol Eden Program

                    int sayi = 0;

                    Console.WriteLine("\nGirilen Sayının Tek Mi Çift Mi Olduğunu Sorgulayan Program (Çıkış: Harf Girişi)\n");

                    try
                    {
                        do
                        {
                            //Kullanıcıdan sayı alındı.
                            Console.Write("\nSayı: ");
                            sayi = int.Parse(Console.ReadLine());

                            // Sayının kontrolü yapıldı. Sayı ekranda yazdırıldı.
                            if (sayi == 0)
                            {
                                Console.WriteLine("Sayı nötr haldedir.");
                            }
                            else if (sayi % 2 == 1 && sayi > 0)
                            {
                                Console.WriteLine($"{sayi} sayısı pozitif tek sayıdır.");
                            }
                            else if (sayi % 2 == 0 && sayi > 0)
                            {
                                Console.WriteLine($"{sayi} sayısı pozitif çift sayıdır.");
                            }
                            else if (sayi % 2 != 0 && sayi < 0)
                            {
                                Console.WriteLine($"{sayi} sayısı negatif tek sayıdır.");
                            }
                            else if (sayi % 2 == 0 && sayi < 0)
                            {
                                Console.WriteLine($"{sayi} sayısı negatif çift sayıdır.");
                            }

                        } while (sayi.GetType().ToString() == "System.Int32");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nHata:\n{ex}\n\nÇıkış Yapılıyor.");
                    }
                }
                else
                {
                    // WHILE ÖRNEĞİ: İlk 100 sayının toplamını hesaplayan program.

                    int sayi = 0, sayilarToplami = 0;

                    Console.WriteLine("\nİlk 100 Sayıyı Toplayıp Ekranda Yazdıran Program\n");

                    while (sayi < 100)
                    {
                        sayilarToplami = sayilarToplami + sayi;
                        sayi++;

                        Console.WriteLine($"{sayi} sayının toplamı: {sayilarToplami}");
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
