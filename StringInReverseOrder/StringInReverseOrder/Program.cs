using System;

namespace StringInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            Console.WriteLine(StringInReverseOrder("qwerty"));
            Console.WriteLine(StringInReverseOrder("oe93 kr"));
        }

        static string StringInReverseOrder(string input)
        {
            // Convert the string to a character array, reverse it, and create a new string
            char[] charArray = input.ToCharArray();

            // Reverse the character array
            Array.Reverse(charArray);

            // Return the new reversed string
            return new string(charArray);
        }
    }
}
