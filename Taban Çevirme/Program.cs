using System;

namespace Taban_Çevirme
{
    class Program
    {
        //verilen sayıyı verilen tabana çeviren metot
        static int[] TabanaÇevir(int Parametre1, int Parametre2) //geriye dizi döndürdüğü için
        {
            int[] sonuç = new int[0]; //başlangıç için 0 tanımlıyoruz
            int Kalan;
            while (Parametre1 != 0)
            {
                Kalan = Parametre1 % Parametre2;
                Array.Resize(ref sonuç, sonuç.Length + 1);
                sonuç[sonuç.Length - 1] = Kalan;
                Parametre1 = (Parametre1 - Kalan) / Parametre2;
            }
            Array.Reverse(sonuç);
            return sonuç;

        }
        //---------------------------
        //verilen diziyi ekrana yazan metot
        static void DiziYaz(int[] Dizi)
        {
            for (int i = 0; i < Dizi.Length; i++)
            {
                Console.Write(Dizi[i]);
            }

        }
        //----------------------------------
        static void Main(string[] args)
        {
            Console.Write("10'luk tabanda bir sayı girin: "); int Sayı = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayıyı çevirmek istediğiniz tabanı girin: "); int Taban = Convert.ToInt32(Console.ReadLine());

            DiziYaz(TabanaÇevir(Sayı, Taban));
            Console.ReadLine();
        }
    }
}
