using System;

namespace VeriTurleriOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string ornekMetin = "OpenAI";
            int sayi = 7;
            double sayi2 = 7.777;
            float deger = 120.5f;
            double pi = 3.1415926535;

            Console.WriteLine("String " + TersCevir(ornekMetin));
            Console.WriteLine("Int : " + KareAl(sayi));
            Console.WriteLine("Float : " + YuzdeHesapla(deger, 20f));
            Console.WriteLine("Double: " + Yuvarla(pi, 3,sayi2));

            Console.WriteLine("Program bitti");
            Console.ReadKey();
        }
        public static string TersCevir(string metin)
        {
            char[] karakterler = metin.ToCharArray();
            Array.Reverse(karakterler); 
            return new string(karakterler);
        }

        public static int KareAl(int sayi)
        {
            return sayi * sayi;
        }
        public static float YuzdeHesapla(float deger, float yuzde)
        {
            return deger * (yuzde / 100f);
        }

        public static double Yuvarla(double sayi, int basamak,double sayi2)
        {
            return sayi * sayi2;
        }
    }
}

