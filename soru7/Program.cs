using System.Xml.Linq;

namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: 7- kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız. (For döngüsü kullanınız.)

            int ilkSinav = 0, ikinciSinav = 0, ucuncuSinav = 0, ortalama = 0, ogrenciSayisi = 0;

            while (true)
            {
                try
                {
                    Console.Write("Notu girilecek öğrenci sayısını girin: ");
                    ogrenciSayisi = int.Parse(Console.ReadLine());
                    if (ogrenciSayisi > 100 || ogrenciSayisi < 1)
                    {
                        Console.Write("Hata: Geçersiz öğrenci sayısı girişi! Lütfen tekrar deneyin.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    for (int i = 0; i < ogrenciSayisi; i++)
                    {
                        Console.Write("\nAdınızı giriniz: ");
                        string adi = Console.ReadLine();
                        if (!GecerliMi(adi))
                        {
                            Console.Write("Hata: Geçersiz ad girişi! Lütfen tekrar deneyin.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        Console.Write("Soyadınızı giriniz: ");
                        string soyadi = Console.ReadLine();
                        if (!GecerliMi(soyadi))
                        {
                            Console.Write("Hata: Geçersiz soyad girişi! Lütfen tekrar deneyin.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        Console.Write("\nİlk sınav notunuzu giriniz: ");
                        ilkSinav = int.Parse(Console.ReadLine());
                        if (!SinirdaMi(ilkSinav))
                        {
                            Console.Write("Hata: Geçersiz not girişi! Lütfen tekrar deneyin.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        Console.Write("\nİkinci sınav notunuzu giriniz: ");
                        ikinciSinav = int.Parse(Console.ReadLine());
                        if (!SinirdaMi(ikinciSinav))
                        {
                            Console.Write("Hata: Geçersiz not girişi! Lütfen tekrar deneyin.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        Console.Write("\nÜçüncü sınav notunuzu giriniz: ");
                        ucuncuSinav = int.Parse(Console.ReadLine());
                        if (!SinirdaMi(ucuncuSinav))
                        {
                            Console.Write("Hata: Geçersiz not girişi! Lütfen tekrar deneyin.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        ortalama = (ilkSinav + ikinciSinav + ucuncuSinav) / 3;

                        Console.WriteLine($"\nÖğrencinin;\nAdı: {adi}\nSoyadı: {soyadi}\nSınavları Ortalaması: {ortalama}");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write($"\nHata:\n{ex}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static bool GecerliMi(string metin)
        {
            foreach (char karakter in metin)
            {
                if (char.IsDigit(karakter))
                {
                    return false;
                }
            }
            return true;
        }

        static bool SinirdaMi(int sayi)
        {
            if (sayi >= 0 && sayi <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
