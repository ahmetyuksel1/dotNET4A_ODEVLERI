using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: 1 - "switch case" yapısı ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritmayı yazınız. Veriyi kullanıcıdan alınız.

            /*
             * Algoritma:
             * 1) Başla.
             * 2) Kullanıcıdan sipariş numarasını al.
             * 3) Sipariş numarasına göre hangi ürünün sipariş edildiğini belirle.
             * 4) Ekrana sipariş edilen ürünü yazdır.
             * 5) Bitir.
             */

            // Ürün isimleri listelendi.
            List<string> urunler = new List<string> { "Iphone 15 Pro Max - 1 TB Siyah Titanyum", "Samsung Galaxy Z Fold 5 - 1 TB Mavi", "Xiaomi 13 Ultra - 1 TB Yeşil " };

            int siparisNo = 0;

            Console.WriteLine("Sipariş Numarasına Bağlı Ürün Sorgulama (Çıkış: Harf Girişi)\n");

            while ((siparisNo >= int.MinValue && siparisNo <= int.MaxValue))
            {
                try
                {
                    // Kullanıcıdan sipariş numarası alındı.
                    Console.Write("Sipariş numarasını giriniz: ");
                    siparisNo = Convert.ToInt32(Console.ReadLine());

                    // Sipariş numarasına göre hangi ürünün sipariş edildiği ekranda yazdırıldı.
                    switch (siparisNo)
                    {
                        case 0:
                            Console.WriteLine($"Çıkış Yapıldı.");
                            break;
                        case 1:
                            Console.WriteLine($"Sipariş edilen ürün: {urunler[0]}\n");
                            continue;
                        case 2:
                            Console.WriteLine($"Sipariş edilen ürün: {urunler[1]}\n");
                            continue;
                        case 3:
                            Console.WriteLine($"Sipariş edilen ürün: {urunler[2]}\n");
                            continue;
                        default:
                            Console.WriteLine("Belirtilen sipariş numarasına ait bir ürün yok.\n");
                            continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Girilen sipariş numarası hatalı. Çıkış Yapıldı.\n");
                    break;
                }
            }
        }
    }
}
