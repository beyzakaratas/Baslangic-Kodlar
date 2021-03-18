using System;

namespace Faktöriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan sayı al
            Console.Write("0 ile 20 arasında bir sayı girin: ");
            int sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı < 0 || sayı > 20)
            {
                Console.WriteLine("Girdiğiniz sayı 0 ile 20 arasında değil!!!");

            }

            else
            {
                double faktöriyel = 1;

                //aldığın sayının faktöriyelini hesapla
                for (int i = 2; i <= sayı; i++)

                    faktöriyel *= i;


                //sonucu ekrana yazdır.
                Console.WriteLine("Girdiğiniz sayının faktöriyeli= " + faktöriyel);



            }


            Console.ReadLine();
        }
    }
}
