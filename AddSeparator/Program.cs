using System;

namespace AddSeparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test metoden med de givne eksempler
            Console.WriteLine(AddSeparator("ABCD", "^"));
            Console.WriteLine(AddSeparator("chocolate", "-"));
        }

        static string AddSeparator(string input, string separator)
        {   
            string result = "";
            // Gennemløb hvert tegn i input-strengen
            foreach (char c in input)
            {
                // Tilføj hvert tegn efterfulgt af separatoren
                result += c + separator;
            }
            // Fjern den sidste separator før resultatet returneres
            return result.TrimEnd(separator[0]);
        }
    }
}
