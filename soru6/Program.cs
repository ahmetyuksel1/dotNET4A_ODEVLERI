using System.Diagnostics.Metrics;

namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: 6- String metotlarını araştırınız. Her bir metot için örnek yapınız.

            string ad = "Ahmet";
            string soyad = "Yüksel";

            // Contains("el") => Aranan harf ya da kelimenin olma durumunu kontrol eder. (True - False)
            bool eVarMi = ad.Contains('e');
            Console.WriteLine(eVarMi);

            // EndsWith('z') => Metnin sonunda aranan harf ya da kelimenin olma durumunu kontrol eder. (True - False)
            bool sondaElVarMi = soyad.EndsWith("el");
            Console.WriteLine(sondaElVarMi);

            // StartsWith('a') => Metnin başında aranan harf ya da kelimenin olma durumunu kontrol eder. (True - False)
            bool bastaYuVarMi = soyad.StartsWith("Yu");
            Console.WriteLine(bastaYuVarMi);

            // Insert(indexNo, "abc") => Belirtilen index'ten sonra istenilen metinsel parçayı ekler.
            soyad = soyad.Insert(3, "sel");
            Console.WriteLine(soyad);

            // Remove() => Belirtilen indexten sonrasını veya belirtilen indexten sonra belirtilen karakterde metin parçasını siler.
            string silinecekMetin = "aspdotnetcoremvc";
            Console.WriteLine(silinecekMetin.Remove(3, 3));

            // Replace(' ', '-') => Metinde belirtlien karakterleri değiştirir.
            string degistirilecekMetin = "Ahmet Yüksel 4A";
            Console.WriteLine(degistirilecekMetin.Replace(' ', '-'));

            // Substring(4, 2) => Belirtilen index'ten itibaren veya o indexten sonra belirtilen karakterde parça alır.
            string alinacakParca = "İstanbul";
            Console.WriteLine(alinacakParca.Substring(3, 2));

            // ToLower() => Metindeki bütün harfleri küçük yapar.
            Console.WriteLine(ad.ToLower());

            // ToUpper => Metindeki bütün harfleri büyük yapar.
            Console.WriteLine(ad.ToUpper());

            // Split() => Kelimeler arasına ayraç olarak koyulan karakterle işlem yapar.
            string bolunecekMetin = "İstanbul,Ankara,İzmir";

            string[] bolunecekMetin2 = bolunecekMetin.Split(',');

            for (int i = 0; i < bolunecekMetin2.Length; i++)
            {
                Console.WriteLine(bolunecekMetin2[i]);
            }

            // Trim() => Metnin başı ve sonundaki boşlukları siler.
            string tiraslanacakMetin = "  Selam, bu trimlenecek bir metindir.     x";
            Console.WriteLine(tiraslanacakMetin.Trim());

            // TrimEnd() => Metnin sonundaki boşlukları siler.
            string tiraslanacakMetin2 = "  Selam, bu trimlenecek bir metindir.     ";
            Console.WriteLine(tiraslanacakMetin2.TrimEnd());


            // TrimStart() => Metnin başındaki boşlukları siler.
            string tiraslanacakMetin3 = "  Selam, bu trimlenecek bir metindir.     x";
            Console.WriteLine(tiraslanacakMetin3.TrimStart());
        }
    }
}
