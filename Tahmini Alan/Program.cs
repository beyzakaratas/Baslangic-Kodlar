using System;

namespace Tahmini_Alan
{
    class Program
    {
        static void Main(string[] args)
        {
            //deney sayısı kullanıcıdan alınsın
            Console.Write("Deney sayısını girin: ");
            int DeneySayısı = Convert.ToInt32(Console.ReadLine());

            //değişken tanımlamaları
            double x, y, alan;
            int EğrininAltındakiNoktaSayısı = 0;
            Random KoordinatÜret = new Random();

            //deney döngüsü
            for (int i = 0; i < DeneySayısı; i++)
            {
                x = KoordinatÜret.NextDouble() * 10;
                y = KoordinatÜret.NextDouble() * 100;
                if (y <= Math.Pow(x, 2))

                    EğrininAltındakiNoktaSayısı++;
            }
            alan = ((double)EğrininAltındakiNoktaSayısı / DeneySayısı) * 1000;
            Console.WriteLine("Tahmini alan= " + alan);
            Console.ReadLine();
        }
    }
}
