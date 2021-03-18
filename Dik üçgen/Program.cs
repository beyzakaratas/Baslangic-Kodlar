using System;

namespace Dik_üçgen
{
    class Program
    {
        static void Main(string[] args)
        {
            DikÜçgen Üçgen = new DikÜçgen();
            // ÇAĞRILIŞ SIRASI ÖNEMLİ
            Üçgen.BilgiAl();
            Üçgen.Hesapla();
            Üçgen.Raporla();

            Console.ReadLine();
        }
    }
}
