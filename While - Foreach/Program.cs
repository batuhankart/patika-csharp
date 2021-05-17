using System;

namespace While___Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program.
            // Console.WriteLine("Lütfen bir sayı girin: );
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi)
            // {
            //      toplam += sayac;
            //      sayac++;   
            // }
            // Console.WriteLine(toplam / sayi);

            // 'a' - 'z' tüm harfleri console'a yazdırın.
            // char character = 'a';
            // while (character = < 'z')
            // {
            //      Console.Write(character);
            //      character++;    
            // }

            Console.Write("***** Foreach *****");
            String[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
