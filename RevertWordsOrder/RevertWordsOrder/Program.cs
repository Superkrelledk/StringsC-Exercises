using System;

namespace RevertWordsOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevertWordsOrder("John Doe."));
            Console.WriteLine(RevertWordsOrder("A, B. C"));
        }

        static string RevertWordsOrder(string input)
        {
            // Definer skilletegnene som skal bruges til at splitte ordene
            char[] delimiters = new char[] { ' ', ',', '.', '!', '?' };

            // Splitter input-strengen i ord, fjerner tomme oppføringer
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
            // Reverserer rekkefølgen på ordene
            Array.Reverse(words);

            // Slår ordene sammen tilbage til en enkelt streng med mellemrum som skilletegn
            return string.Join(" ", words);
        }
    }
}
