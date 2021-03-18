using System;

namespace Matrisler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kare matris boyutu girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] Amatrisi = new int[n, n];
            int[,] Bmatrisi = new int[n, n];
            int[,] toplam = new int[n, n];
            int[,] matrislerinçarpımı = new int[n, n];
            Random rastgele = new Random();

            Console.WriteLine();
            Console.WriteLine("A Matrisi:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Amatrisi[i, j] = rastgele.Next(0, 9);
                    Console.Write(Amatrisi[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("B Matrisi:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Bmatrisi[i, j] = rastgele.Next(0, 9);
                    Console.Write(Bmatrisi[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //1.matris ile 2.matrisi toplama.
            Console.WriteLine("İki Matrisin Toplamı: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    toplam[i, j] = Amatrisi[i, j] + Bmatrisi[i, j];
                    Console.Write(toplam[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("İki Matrisin Çarpımı:");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    for (int k = 0; k < n; k++)
                    {
                        matrislerinçarpımı[i, j] += Amatrisi[i, k] * Bmatrisi[k, j];

                    }

                    Console.Write(matrislerinçarpımı[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
