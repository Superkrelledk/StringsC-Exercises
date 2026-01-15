using System;

namespace NumbersOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumbersOfWords("This is Samle sentence"));
            
            Console.WriteLine(NumbersOfWords("Ok"));
            Console.ReadLine();
        }


        static int NumbersOfWords(string input)
        {
            int length = 0;
            foreach (char c in input)
            {
                // Mellemrum tæller som et ord
                if (c == ' ')
                {
                    // Øg længden med 1 for hvert mellemrum
                    length++;
                }
            }
            // Tilføj 1 for det sidste ord, der ikke følges af et mellemrum
            return length + 1;
        }
    }
}
