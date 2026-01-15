using System;

namespace SortCharactersDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortCharactersDescending("onomatopoeia"));
            Console.WriteLine(SortCharactersDescending("fohjwf42os"));
            Console.ReadLine();
        }

        // Metode til at sortere karakterer i faldende rækkefølge
        public static string SortCharactersDescending(string text)
        {
            // Konverter teksten til et char-array
            char[] chars = text.ToCharArray();
            
            // Sorter array i stigende rækkefølge
            Array.Sort(chars);
            
            // Vend array om for faldende rækkefølge
            Array.Reverse(chars);
            
            // Returner som en string
            return new string(chars);
        }

    }
}
