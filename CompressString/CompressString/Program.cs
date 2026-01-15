using System;

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompressString("kkkktttrrrrrrrrrr")); // Forventet: k4t3r10
            Console.WriteLine(CompressString("p555ppp7www"));        // Forventet: p153p371w3
        }
        static string CompressString(string input)
        {
            // Tomt tekst? Returner det samme
            if (string.IsNullOrEmpty(input))
                return input;

            string result = ""; // Det komprimerede resultat

            // Start med første tegn
            char nuværendeTegn = input[0];
            int antal = 1;

            // Gennemgå resten af teksten
            for (int i = 1; i < input.Length; i++)
            {
                // Er det samme tegn?
                if (input[i] == nuværendeTegn)
                {
                    antal++; // Tæl én mere
                }
                else
                {
                    // Nyt tegn fundet - gem det forrige
                    result = result + nuværendeTegn + antal;
                    
                    // Skift til det nye tegn
                    nuværendeTegn = input[i];
                    antal = 1;
                }
            }

            // Husk at tilføje det sidste tegn
            result = result + nuværendeTegn + antal;

            return result;
        }
    }
}
