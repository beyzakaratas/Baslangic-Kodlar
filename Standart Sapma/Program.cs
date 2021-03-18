using System;

namespace Standart_Sapma
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] not = new int[10];
            double ortalama = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ".notu girin: ");
                not[i] = Convert.ToInt32(Console.ReadLine());
                ortalama += not[i];

            }
            Console.WriteLine();
            ortalama /= 10;
            Console.WriteLine("Ortalama= " + ortalama);

            double karetoplamı = 0;
            for (int i = 0; i < 10; i++)
            {
                double Fark = not[i] - ortalama;
                double FarkKare = Math.Pow(Fark, 2);
                karetoplamı += FarkKare;
            }
            double standartsapma = karetoplamı / 9;
            standartsapma = Math.Sqrt(standartsapma);
            Console.WriteLine("Standart sapma= " + standartsapma);


            Console.ReadLine();
        }
    }
}
