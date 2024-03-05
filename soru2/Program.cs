namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: 2- Kullanıcıya kaç ürün almak istediğini soran; her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan algoritmayı yazınız. (Veriyi kullanıcıdan alın ve döngü için "for döngüsü" kullanınız.)

            /*
             * Algoritma:
             * 1) Başla.
             * 2) Kullanıcıdan kaç ürün almak istediğini al.
             * 3) Kullanıcıdan her ürünün fiyatını al.
             * 4) Alışverişin toplam tutarını hesapla.
             * 5) Ekrana toplam ürün adedi ve toplam alışveriş tutarını yazdır.
             * 6) Bitir.
             */

            int toplamAdet = 1, toplamFiyat = 0;

            Console.WriteLine("Alınacak Ürün Adedine Göre Ürünlerin Toplam Tutarını Hesaplama (Çıkış: Harf Girişi)\n");

            while (toplamAdet >= 1 && toplamAdet <= int.MaxValue) 
            {
                try
                {
                    Console.Write("Kaç ürün almak istediğinizi giriniz: ");
                    toplamAdet = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i < toplamAdet + 1; i++)
                    {
                        Console.Write($"{i}. ürün fiyatı: ");
                        int urunFiyat = Convert.ToInt32(Console.ReadLine());

                        toplamFiyat = toplamFiyat + urunFiyat;
                    }

                    Console.WriteLine($"\nÜrünlerin toplam adedi: {toplamAdet},\nÜrünlerin toplam fiyatı: {toplamFiyat}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nHata:\n{ex}\n\nÇıkış Yapılıyor.");
                }
            }
        }
    }
}
