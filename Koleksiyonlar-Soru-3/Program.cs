using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string sentence = Console.ReadLine();
            string vowel = "aeıioüuü";

            List<char> vowelsFromSentence = new List<char>();

            foreach (char letter in sentence)
            {
                if (vowel.Contains(letter))
                {
                    vowelsFromSentence.Add(letter);
                }
            }

            vowelsFromSentence.Sort();

            foreach (char letter in vowelsFromSentence)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
