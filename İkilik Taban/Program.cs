using System;

namespace İkilik_Taban
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int kalan;
            string sonuç = "";
            Console.Write("Girilen sayının 2'lik tabandaki karşılığı = ");

            while (sayı != 0)
            {
                kalan = sayı % 2;
                sonuç = kalan + sonuç;
                sayı = (sayı - kalan) / 2;

            }
            Console.Write(sonuç);

            Console.ReadLine();
        }
    }
}
