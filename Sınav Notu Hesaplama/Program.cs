using System;

namespace Sınav_Notu_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vize, Final;
            double GeçmeNotu;

            //vize notunu kullanıcıdan al
            Console.Write("Vize notunu giriniz: ");
            Vize = Convert.ToInt32(Console.ReadLine());

            //final notunu kullanıcıdan al
            Console.Write("Final notunu giriniz: ");
            Final = Convert.ToInt32(Console.ReadLine());



            if (Final >= 35)

            {
                //Geçme notunu hesapla
                GeçmeNotu = 0.4 * Vize + 0.6 * Final;
                GeçmeNotu = Math.Round(GeçmeNotu, 0);
                Console.WriteLine("Geçme Notu\t: " + GeçmeNotu);

                //notları hızlı bir şekilde ekrana yaz.
                Console.WriteLine(); //boş bir satır ekle
                Console.Write("vize\tfinal\tgeçme notu\n");
                Console.Write("--------------------------------\n");
                Console.Write(Vize + "\t" + Final + "\t" + GeçmeNotu + "\n\n");

                //Geçme notuna göre harf belirle
                if (GeçmeNotu >= 82 && GeçmeNotu <= 100)



                    Console.WriteLine("Harf notunuz\t: AA\tKatsayı:4.00");


                else if (GeçmeNotu >= 74 && GeçmeNotu <= 81)

                    Console.WriteLine("Harf notunuz\t: BA\tKatsayı:3.50");

                else if (GeçmeNotu >= 65 && GeçmeNotu <= 73)
                    Console.WriteLine("Harf notunuz\t: BB\tKatsayı:3.00");

                else if (GeçmeNotu >= 58 && GeçmeNotu <= 64)
                    Console.WriteLine("Harf notunuz\t: BC\tKatsayı:2.50");

                else if (GeçmeNotu >= 50 && GeçmeNotu <= 57)
                    Console.WriteLine("Harf notunuz\t: CC\tKatsayı:2.00");

                else
                    Console.WriteLine("Harf notunuz\t: FF\tKatsayı:0.00");


            }
            else
            {
                Console.WriteLine("Harf notunuz\t: FF\tKatsayı:0.00\n(Final 35'ten küçük olduğu için");
            }




            Console.ReadLine();
        }
    }
}
