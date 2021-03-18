using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Terim Sayısı Giriniz: ");
            int TerimSayısı = Convert.ToInt32(Console.ReadLine());
            int Terim1 = 1, Terim2 = 1;

            Console.WriteLine();

            Console.WriteLine("TerimNo\tTerim\tOran");
            Console.WriteLine("-------\t-----\t----");
            Console.WriteLine("1\t" + Terim1);
            Console.WriteLine("2\t" + Terim2 + "\t" + Terim2 / Terim1);

            for (int i = 3; i <= TerimSayısı; i++)
            {
                int SıradakiTerim = Terim1 + Terim2;
                double Oran = (double)SıradakiTerim / Terim2;

                Console.WriteLine(i + "\t" + SıradakiTerim + "\t" + Oran);

                Terim1 = Terim2;
                Terim2 = SıradakiTerim;
            }

            Console.ReadLine();
        }
    }
}
