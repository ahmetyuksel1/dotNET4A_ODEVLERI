namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: 7- kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız. (For döngüsü kullanınız.)

            int ilkSinav = 0, ikinciSinav = 0, ucuncuSinav = 0, ortalama = 0, ogrenciSayisi = 0;

            while (ogrenciSayisi < 100)
            {
                try
                {
                    Console.Write("Notu girilecek öğrenci sayısını girin: ");
                    ogrenciSayisi = byte.Parse(Console.ReadLine());

                    for (int i = 0; i < ogrenciSayisi; i++)
                    {
                        Console.Write("\nAdınızı giriniz: ");
                        string adi = Console.ReadLine();

                        Console.Write("Soyadınızı giriniz: ");
                        string soyadi = Console.ReadLine();

                        Console.Write("\nİlk sınav notunuzu giriniz: ");
                        ilkSinav = byte.Parse(Console.ReadLine());

                        Console.Write("\nİkinci sınav notunuzu giriniz: ");
                        ikinciSinav = byte.Parse(Console.ReadLine());

                        Console.Write("\nÜçüncü sınav notunuzu giriniz: ");
                        ucuncuSinav = byte.Parse(Console.ReadLine());

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
    }
}
