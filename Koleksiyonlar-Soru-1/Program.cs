using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumber = new ArrayList();
            ArrayList notPrimeNumber = new ArrayList();

            int givenNumber = 0;
            while (givenNumber < 20)
            {
                Console.Write("{0}. sayıyı giriniz: ", givenNumber + 1);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number) && number >= 0)
                {
                    if (IsPrime(number))
                        primeNumber.Add(number);
                    else
                        notPrimeNumber.Add(number);

                    givenNumber++;
                }
                else
                    Console.WriteLine("\nHatalı giriş yaptınız! Lütfen Tekrar Deneyin.\n");
            }

            primeNumber.Sort();
            notPrimeNumber.Sort();
            primeNumber.Reverse();
            notPrimeNumber.Reverse();

            int primeTotal = 0;
            int notPrimeTotal = 0;

            Console.WriteLine("\n***** Asal Sayılar *****");
            foreach (int number in primeNumber)
            {
                Console.WriteLine(number);
                primeTotal += number;
            }
            
            Console.WriteLine("\n***** Asal Olmayan Sayılar *****");
            foreach (int number in notPrimeNumber)
            {
                Console.WriteLine(number);
                notPrimeTotal += number;
            }

            Console.WriteLine("\nAsal sayılar dizisinin eleman sayısı = {0} ve ortalaması = {1}", primeNumber.Count, primeTotal / primeNumber.Count);
            Console.WriteLine("Asal olmayan sayılar dizisinin eleman sayısı = {0} ve ortalaması = {1}", notPrimeNumber.Count, notPrimeTotal / notPrimeNumber.Count);
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
