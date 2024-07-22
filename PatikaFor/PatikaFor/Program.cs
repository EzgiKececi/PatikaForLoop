
using System;

namespace forLoop
{
    class Program
    {
        static void Main()
        {
            int i; // ---> Tüm uygulamalar için ortak i değişkeni.



            // 1. Uygulama -- 10 kez istenildiği için koşul i<11 olarak verildi.

            for (i = 1; i < 11; i++)
            {
                Console.WriteLine("Kendime inanıyorum, bu yazılım işini halledeceğim!");
            }
            Console.WriteLine("\n\n"); // Konsolda diğer örnekle karışmaması adına eklenmiştir.

            //2. Uygulama -- 1 ve 20 sayıları dahil edilmedi.

            for (i = 2; i < 20; i++)
            {
                Console.WriteLine($"1 ile 20 arasındaki sayılar: {i}");
            }
            Console.WriteLine("\n\n");

            //3. Uygulama --1 ve 20 sayıları dahil edilmedi. Bu sayılar arasındaki ilk çift sayı 2'dir ve +=2 operatörü kullanılarak diğer çift sayılar elde edildi.

            for (i = 2; i < 20; i += 2)
            {
                Console.WriteLine($"1 ile 20 arasındaki çift sayılar: {i}");
            }
            Console.WriteLine("\n\n");

            //4. Uygulama --- 50 ve 150 sayıları dahil edilmedi
            int toplam = 0;
            for (i = 51; i < 150; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"50 ve 150 arasındaki tüm sayıların toplamı: {toplam}");
            Console.WriteLine("\n\n");

            //5.Uygulama -- 1 ve 120 sayıları dahil edilmedi
            //5.1 -- ilk çift sayı 2'dir. +=2 operatörü ile diğer çift sayılar elde edilmiştir.
            int çiftToplam = 0;
            for (i = 2; i < 120; i += 2)
            {
                çiftToplam += i;
            
            }
            Console.WriteLine($"Çift sayıların toplamı: {çiftToplam}\n");

            //5.2
            int tekToplam = 0;
            for (i = 3; i < 120; i += 2)
            {
                tekToplam += i;
           
            }
            Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");

        }
    }
}

