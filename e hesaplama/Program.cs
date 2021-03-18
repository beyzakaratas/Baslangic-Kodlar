using System;

namespace e_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            // x reel sayısını kullanıcıdan al.
            Console.Write("x sayısını girin(reel sayı): ");
            double X = Convert.ToDouble(Console.ReadLine());

            // n sayısını kullanıcıdan al.
            Console.Write("n sayısını girin(tam sayı): ");
            int N = Convert.ToInt32(Console.ReadLine());

            // e üzeri x hesabı.
            double sonuç = 0;

            for (int i = 0; i <= N; i++)
            {
                //payın hesaplanması.
                double pay = Math.Pow(X, i);

                //paydanın hesaplanması.
                double payda = 1;

                for (int j = 2; j <= i; j++)//i faktöriyelin hesabı


                    payda *= j;

                //bölümün hesaplanıp sonucun üstüne eklenmesi.
                sonuç += pay / payda;


            }
            Console.WriteLine();
            Console.WriteLine("e üzeri" + X + "= " + sonuç);
            Console.WriteLine("gerçek değer= " + Math.Pow(Math.E, X));


            Console.ReadLine();
        }
        
    }
}
