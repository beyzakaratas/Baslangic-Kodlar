using System;
using System.Collections.Generic;
using System.Text;

namespace Dik_üçgen
{
    class DikÜçgen // CLASSIN İÇİNDE KOD YAZILMAZ SADECE TANIMLAMALAR YAPILABİLİR
    {
        private int kenar1, kenar2;
        private double hipotenüs, alan, çevre; // başına private yazmasaydın da otomatik private tanımlardı

        public void BilgiAl() // metot içinde yazdığın kodlarda bilgiye ihtiyacın yok bu yüzden parematre almıyor.
        {
            Console.Write("Dik üçgenin 1.dik kenar uzunluğunu giriniz: ");
            kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dik üçgenin 2.dik kenar uzunluğunu giriniz: ");
            kenar2 = Convert.ToInt32(Console.ReadLine());
        }
        public void Hesapla()
        {
            hipotenüs = Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2));
            çevre = hipotenüs + kenar1 + kenar2;
            alan = kenar1 * kenar2 / 2.0;

        }
        public void Raporla()
        {
            Console.WriteLine();
            Console.WriteLine("Dik üçgenin 1.kenar uzunluğu: " + kenar1);
            Console.WriteLine("Dik üçgenin 2.kenar uzunluğu: " + kenar2);
            Console.WriteLine("Dik üçgenin hipotenüsü: " + hipotenüs);
            Console.WriteLine("Dik üçgenin çevresi: " + çevre);
            Console.WriteLine("Dik üçgenin alanı: " + alan);
        }
    }
}
