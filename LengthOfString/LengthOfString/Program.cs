using System;

namespace LengthOfString
{
    internal class Program
    {
        // Hovedprogrammet - kalder metoden med testeksempler
        static void Main(string[] args)
        {
            // Udskriver længden af "computer" (forventet: 8)
            Console.WriteLine(LengthOfAString("computer"));
            
            // Udskriver længden af "ice cream" (forventet: 9)
            Console.WriteLine(LengthOfAString("ice cream"));
        }

        // Metode der beregner længden af en streng uden at bruge biblioteksmetoder
        static int LengthOfAString(string input)
        {
            // Tæller antallet af tegn i strengen
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }
            return length;
        }
    }
}
