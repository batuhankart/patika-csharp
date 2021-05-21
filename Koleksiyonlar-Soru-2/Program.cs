using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write(i + 1 + ". sayıyı giriniz: ");
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            Array.Sort(numbers);

            int smallestTotal = 0;
            for (int i = 0; i < 3; i++)
            {
                smallestTotal += numbers[i];
            }

            int biggestTotal = 0;
            for (int i = numbers.Length - 1; i > numbers.Length - 4; i--)
            {
                biggestTotal += numbers[i];
            }

            float smallestAvg = (float)smallestTotal / 3;
            float biggestAvg = (float)biggestTotal / 3;
            Console.WriteLine("\nEn küçük 3 sayının ortalaması = {0}\nEn büyük 3 sayının ortalaması = {1}\nOrtalama toplamları = {2}\n", smallestAvg, biggestAvg, smallestAvg + biggestAvg);
            
        }
    }
}
