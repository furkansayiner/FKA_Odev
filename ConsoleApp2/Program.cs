using System;

namespace ConsoleApp2

{
    class Sekil
    {
        public string Tur;

        public Sekil(string tur)
        {
            Tur = tur;
            Console.WriteLine("Şekil sınıfı çalıştı.");
        }

        public void Tanit()
        {
            Console.WriteLine("Bu bir " + Tur + " şeklidir.");
        }
    }

    class Dortgen : Sekil
    {
        public int UzunKenar;
        public int KisaKenar;

        // Dortgen constructor'ı, Sekil sınıfının constructor'ını parametre olarak çağırıyor.
        public Dortgen(string tur, int uzunKenar, int kisaKenar) : base(tur)
        {
            UzunKenar = uzunKenar;
            KisaKenar = kisaKenar;
            Console.WriteLine("Dörtgen sınıfı çalıştı.");
        }

        public void AlanHesapla()
        {
            int alan = UzunKenar * KisaKenar;
            Console.WriteLine("Dörtgenin Alanı: " + alan);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dortgen dikdortgen = new Dortgen("Dikdörtgen", 5, 3);
            dikdortgen.Tanit(); // Tanit metodunu çağırarak Şekil sınıfının metodunu çalıştırıyoruz.
            dikdortgen.AlanHesapla(); // AlanHesapla metodunu çağırarak Dortgen sınıfının metodunu çalıştırıyoruz.
        }
    }
}
