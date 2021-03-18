using System;

namespace Diziler
{
    class Program
    {


        //verilen diziyi ekrana yazan metot
        static void diziyaz(string metin, int[] dizi)
        {
            Console.WriteLine();
            Console.WriteLine(metin);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + "-");
            }
            Console.WriteLine();
        }
        //------------------------------------------
        static void Main(string[] args)
        {

            int[] Sayılar = { 9, 1, 5, 7, 2, 0, 6, 4, 3, 8 };


            Console.WriteLine("Dizinin Eleman Sayısı: " + Sayılar.Length);
            Console.WriteLine("Dizinin Boyut Sayısı: " + Sayılar.Rank);


            diziyaz("dizinin orijinal hali", Sayılar);

            Array.Sort(Sayılar);
            diziyaz("Dizinin Sıralanmış Hali", Sayılar);

            Array.Reverse(Sayılar, 3, 4);
            diziyaz("Dizinin Kısmen Ters Çevrilmiş Hali", Sayılar);

            Array.Clear(Sayılar, 4, 3);
            diziyaz("Dizinin Kısmen Temizlenmiş Hali", Sayılar);

            Array.Resize(ref Sayılar, Sayılar.Length + 3);
            diziyaz("Dizinin Yeniden Boyutlanmış Hali", Sayılar);

            Console.WriteLine("\nDizide 4 nın yeri:" + Array.IndexOf(Sayılar, 4));


            Console.ReadLine();


        }
    }
}
