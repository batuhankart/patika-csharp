using System;

namespace Ödev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("***** Çift Sayıları Yazdır *****\n");
            Console.Write("Pozitif bir sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. pozitif sayıyı girin: ", i + 1);
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    Console.WriteLine("\nGirdiğiniz {0} sayısı çift sayıdır.", input);
                }
            }
            */

            /*
            Console.WriteLine("***** Tam Bölünenleri Yazdır *****\n");
            Console.Write("1. pozitif sayıyı girin: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("2. pozitif sayıyı girin: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. pozitif sayıyı girin: ", i + 1);
                int input = int.Parse(Console.ReadLine());

                if (input == m || input % m == 0)
                {
                    Console.WriteLine("\nGirdiğiniz {0} sayısı {1} sayısına tam bölünüyor.", input, m);
                }
            }
            */

            /*
            Console.WriteLine("***** Kelimeleri Sondan Başa Yazdır *****");
            
            Console.Write("Pozitif bir sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelimeyi girin: ", i + 1);
                string kelime = Console.ReadLine();
                kelimeler[i] = kelime;
            }

            Array.Reverse(kelimeler);

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            */

            Console.WriteLine("***** Harf ve Kelimele Sayısını Yazdır *****");

            Console.Write("Bir cümle girin: ");
            string cümle = Console.ReadLine();
            cümle.ToLower();

            int kelime = 0;
            int harf = 0;

            foreach (char c in cümle)
            {
                if (c == ' ')
                {
                    kelime++;
                }
                else if ((int)c >= 97 && (int)c <= 122)
                {
                    harf++;
                }
            }

            Console.WriteLine("Girdiğinizi cümlede {0} adet harf ve {1} adet kelime var.", harf, kelime + 1);
        }
    }
}
