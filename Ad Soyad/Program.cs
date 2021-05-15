using System;

namespace Ad_Soyad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Console.Write("Adınızı Girin: ");
            string name = Console.ReadLine();

            Console.Write("Soyadınızı Girin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("\nMerhaba, " + name + " " + surname);
        }
    }
}
