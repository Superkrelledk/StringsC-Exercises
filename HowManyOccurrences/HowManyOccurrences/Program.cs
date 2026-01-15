using System;

namespace HowManyOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyOccurrences("do it now", "do"));
            Console.WriteLine(HowManyOccurrences("empty", "d"));
            Console.ReadLine();
        }

        // Funktion der tæller hvor mange gange en substring forekommer i en tekst
        public static int HowManyOccurrences(string text, string sub)
        {
            // Returner 0 hvis en af strengene er tom eller null
            if (string.IsNullOrEmpty(sub) || string.IsNullOrEmpty(text))
                return 0;

            int count = 0; // Tæller for antal forekomster
            int index = 0; // Aktuel position i teksten

            // Søg efter substring - fortsæt indtil der ikke er flere forekomster
            while ((index = text.IndexOf(sub, index)) != -1)
            {
                count++; // Tæller når vi finder substring
                index += sub.Length; // Flyt position fremad
            }

            return count; // Returner totalt antal forekomster
        }

    }
}
